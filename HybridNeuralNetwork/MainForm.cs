using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace HybridNeuralNetwork
{
    public partial class MainForm : Form
    {
        // Форма для обучения главной нейронной сети
        SetUpMonitoringToolsForm s_Form;
        // Окно ожидания
        WaitWindow w_WaitWindow;
        // Главная нейронная сеть
        MainNeuralNetwork m_MainNeuralNet;
        // Нейросеть из базы знаний
        LayerKnowledgeNet[] l_LayersKnowledgeNet;
        // База знаний
        KnowledgeBase k_Base;
        // Мониторинг
        Monitoring m_Monitoring;

        public MainForm()
        {
            InitializeComponent();

            OpenWaitWindow("Launching the application, please wait...");

            m_MainNeuralNet = new MainNeuralNetwork();
            // Считывание входов и выходов из файлов для обучения, исключения
            string s_InputTrainDataFile = AppDomain.CurrentDomain.BaseDirectory + "InputTrainData.txt";
            string s_OutputTrainDataFile = AppDomain.CurrentDomain.BaseDirectory + "OutputTrainData.txt";
            if (!File.Exists(s_InputTrainDataFile) ||
                !File.Exists(s_OutputTrainDataFile))
            {
                MessageBox.Show("'InputTrainData.txt' or 'OutputTrainData.txt' with data for training are absent, put them in a folder with the application.");
                Close();
            }
            string s_KnowledgeBaseFile = AppDomain.CurrentDomain.BaseDirectory + "KnowledgeBase.n3";
            if (!File.Exists(s_KnowledgeBaseFile))
            {
                MessageBox.Show("'KnowledgeBase.n3' with knowledgebase is absent, put her in a folder with the application.");
                Close();
            }

            int i_InputCount = 0;
            using (StreamReader s_Reader = new StreamReader(s_InputTrainDataFile))
            {
                i_InputCount = s_Reader.ReadLine().Split('\t').Length;
            }
            int i_OutputCount = 0;
            using (StreamReader s_Reader = new StreamReader(s_OutputTrainDataFile))
            {
                i_OutputCount = s_Reader.ReadLine().Split('\t').Length;
            }
            // Подключение к БЗ и получение данных
            k_Base = new KnowledgeBase(s_KnowledgeBaseFile);
            k_Base.GetDataKnowledgeNet();
            l_LayersKnowledgeNet = k_Base.GetKnowledgeNet;

            // Добавление диагностируемых параметров в таблицу
            d_InputTable.Rows.Clear();
            d_InputTable.Rows.Add("Average packet path length, m", "", "");
            d_InputTable.Rows.Add("Network load, bps", "", "");
            d_InputTable.Rows.Add("Data transfer volume, bit", "", "");

            m_Monitoring = new Monitoring(m_MainNeuralNet, l_LayersKnowledgeNet, d_InputTable, p_NetworkStatusPanel,
                c_Graph);

            // Инициализация формы с инструментами для мониторинга
            s_Form = new SetUpMonitoringToolsForm(m_MainNeuralNet, i_InputCount, i_OutputCount, s_InputTrainDataFile, s_OutputTrainDataFile, m_Monitoring);

            CloseWaitWindow();
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
        }

        // Запуск мониторинга
        private void c_RunMonitoringMenu_Click(object sender, EventArgs e)
        {
            if (!m_MainNeuralNet.GetTrainNet)
            {
                MessageBox.Show("Neural network not trained, train it in monitoring tools.");
                return;
            }
            if (!m_Monitoring.GetRun)
            {
                m_Monitoring.RunMonitoring();
                GraphicsForObjects.DrawingStatusMonitoring(p_MonitoringStatusPanel, m_Monitoring.GetRun);
            }               
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
            m_Monitoring.StopMonitoring();
            GraphicsForObjects.DrawingStatusMonitoring(p_MonitoringStatusPanel, m_Monitoring.GetRun);
        }

        // При перерисовке панели перерисовка графики
        private void p_NetworkStatusPanel_Paint(object sender, PaintEventArgs e)
        {
            GraphicsForObjects.DrawingStatusNetwork(p_NetworkStatusPanel, m_Monitoring.GetOutputData,
                new string[] { "Normal work", "Overload", "Failure" }, new Color[] { Color.LawnGreen, Color.Yellow, Color.Red });          
        }

        private void l_NetworkStatus_Paint(object sender, PaintEventArgs e)
        {   
            GraphicsForObjects.DrawingStatusMonitoring(p_MonitoringStatusPanel, m_Monitoring.GetRun);
        }

        // Выход
        private void c_ExitMenu_Click(object sender, EventArgs e)
        {
            m_MainNeuralNet.Dispose();
            k_Base.Dispose();
            Close();
        }
        
        // Открытие журнала
        private void c_OpenMonitoringLogMenu_Click(object sender, EventArgs e)
        {

            if (!m_Monitoring.GetRun)
            {
                // Создание файла, если нет
                if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Log.xlsx"))
                {
                    MessageBox.Show("There is no log file since there was no monitoring.");
                    return;
                }
                Process p_Log = Process.Start("excel.exe", @"""" + AppDomain.CurrentDomain.BaseDirectory + "Log.xlsx" + @"""");
                p_Log.WaitForExit();
            }
        }
    }
}
