using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HybridNeuralNetwork
{
    public partial class MainForm : Form
    {
        // Форма для обучения главной нейронной сети
        SetUpMonitoringToolsForm s_Form;
        // Окно ожидания
        WaitWindow w_WaitWindow;
        // Главная сеть
        MainNetwork m_MainNet;
        // Мониторинг запущен
        bool b_RunMonitoring;

        public MainForm()
        {
            InitializeComponent();
            b_RunMonitoring = false;

            OpenWaitWindow("Запуск приложения, пожалуйста, подождите...");
            m_MainNet = new MainNetwork();
            s_Form = new SetUpMonitoringToolsForm(m_MainNet, 3, 2);
            CloseWaitWindow();

            /*
            // 34.6 2905.614
            double[] d_OutputValues = m_MainNet.RunNet(new double[] { 173, 0.9, 10460209 });*/
            c_Graph.Series["Values"].Points.AddXY(DateTime.Now.ToLongTimeString(), 0);
        }

        // Запуск формы с настройкой нейронной сети
        private void c_SetUpMonitoringToolsMenu_Click(object sender, EventArgs e)
        {
            try
            {
                s_Form.ShowDialog();
            }
            catch (ApplicationException a_Ex)
            {
                MessageBox.Show(a_Ex.Message);
            }
            catch (Exception e_Ex)
            {
                MessageBox.Show("Error code: " + Math.Abs(e_Ex.GetHashCode()) + ". Contact Support.");
            }
            //GraphicsForObjects.DrawingStatusNetwork(p_NetworkStatusPanel, new int[] { 1, 0, 0 },
              //  new string[] { "Normal work", "Overload", "Failure" }, new Color[] { Color.Green, Color.Yellow, Color.Red });
        }

        // Запуск мониторинга
        private void c_RunMonitoringMenu_Click(object sender, EventArgs e)
        {
            
            if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "KnowledgeBase.n3"))
            {
                MessageBox.Show("'KnowledgeBase.n3' with knowledgebase is absent, put her in a folder with the application.");
                return;
            }

            b_RunMonitoring = true;
            GraphicsForObjects.DrawingStatusMonitoring(p_MonitoringStatusPanel, b_RunMonitoring);       
        }

        // Открытие окна ожидания
        private void OpenWaitWindow(string s_Message)
        {
            w_WaitWindow = new WaitWindow(s_Message);
            w_WaitWindow.Show();
            w_WaitWindow.Refresh();
        }

        // Закрытие окна ожидания
        private void CloseWaitWindow()
        {
            w_WaitWindow.Close();
        }

        // Остановка мониторинга
        private void c_StopMonitoringMenu_Click(object sender, EventArgs e)
        {
            b_RunMonitoring = false;
            GraphicsForObjects.DrawingStatusMonitoring(p_MonitoringStatusPanel, b_RunMonitoring);
        }

        // При перерисовке панели перерисовка графики
        private void p_NetworkStatusPanel_Paint(object sender, PaintEventArgs e)
        {
            GraphicsForObjects.DrawingStatusNetwork(p_NetworkStatusPanel, new int[] { 1, 1, 1 },
                new string[] { "Normal work", "Overload", "Failure" }, new Color[] { Color.LawnGreen, Color.Yellow, Color.Red });
            
        }

        private void l_NetworkStatus_Paint(object sender, PaintEventArgs e)
        {   
            GraphicsForObjects.DrawingStatusMonitoring(p_MonitoringStatusPanel, b_RunMonitoring);
        }

        // Выход
        private void c_ExitMenu_Click(object sender, EventArgs e)
        {
            if (m_MainNet!=null)
            {
                m_MainNet.Dispose();
            }
            Close();
        }
    }
}
