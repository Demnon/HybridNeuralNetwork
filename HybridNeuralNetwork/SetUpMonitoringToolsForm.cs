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
    // Форма для обучения главной нейронной сети
    public partial class SetUpMonitoringToolsForm : Form
    {
        // Главная нейронная сеть
        MainNetwork m_MainNet;
        // Количество входов
        int i_InputCount;
        // Количество выходов
        int i_OutputCount;

        public SetUpMonitoringToolsForm(MainNetwork m_MainNet, int i_InputCount, int i_OutputCount)
        {
            InitializeComponent();
            this.m_MainNet = m_MainNet;
            this.i_InputCount = i_InputCount;
            this.i_OutputCount = i_OutputCount;
        }

        private void b_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Обучение
        private void b_Train_Click(object sender, EventArgs e)
        {
            if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory+ "InputTrainData.txt") || 
                !File.Exists(AppDomain.CurrentDomain.BaseDirectory + "OutputTrainData.txt"))
            {
                MessageBox.Show("'InputTrainData.txt' and 'OutputTrainData.txt' with data for training are absent, put them in a folder with the application.");
                return;
            }
            t_TrainingLog.Text = "Launch neural network training..."+Environment.NewLine;
            // Запуск обучения в отдельном потоке
            Task t_Learning = new Task(new Action(StartLearning));
            t_Learning.Start();
        }

        // Запуск обучения и вывод результатов
        private void StartLearning()
        {
            object o_Errors = m_MainNet.TeacherTraining(i_InputCount, i_OutputCount, AppDomain.CurrentDomain.BaseDirectory + "InputTrainData.txt",
                AppDomain.CurrentDomain.BaseDirectory + "OutputTrainData.txt");

            c_GraphPerfErrors.Invoke((Action)delegate
            {
                t_TrainingLog.Text += "Training completed successfully, average learning error: " + ((object[])o_Errors)[0].ToString();
                t_Error.Text = ((object[])o_Errors)[0].ToString();
                // Построение графиков
                double[] d_PerfErrors = (double[])(((object[])o_Errors)[1]);
                double[,] d_AbsErrors = (double[,])(((object[])o_Errors)[2]);
            
                // Построение первого графика
                c_GraphPerfErrors.Series["Values"].Points.Clear();
                bool b_Test = false;
                for (int i = 5; i < d_PerfErrors.Length; i++)
                {
                    if (d_PerfErrors[i] < 0.1 || b_Test)
                    {
                        c_GraphPerfErrors.Series["Values"].Points.AddXY(i, d_PerfErrors[i]);
                        b_Test = true;
                    }
                }
                // Построение второго графика
                c_GraphAbsErrors.Series["Delay time"].Points.Clear();
                c_GraphAbsErrors.Series["Average transfer speed"].Points.Clear();
                for (int i=0;i<d_AbsErrors.GetUpperBound(1)+1;i++)
                {
                    c_GraphAbsErrors.Series["Delay time"].Points.AddXY(i, d_AbsErrors[0,i]);
                }
                for (int i = 0; i < d_AbsErrors.GetUpperBound(1) + 1; i++)
                {
                    c_GraphAbsErrors.Series["Average transfer speed"].Points.AddXY(i, d_AbsErrors[1, i]);
                }
            });
        }
    }
}
