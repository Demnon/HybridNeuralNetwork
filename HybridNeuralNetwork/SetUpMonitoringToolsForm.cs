using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HybridNeuralNetwork
{
    // Форма для обучения главной нейронной сети
    public partial class SetUpMonitoringToolsForm : Form
    {
        // Главная нейронная сеть
        MainNeuralNetwork m_MainNet;
        // Количество входов
        int i_InputCount;
        // Количество выходов
        int i_OutputCount;
        // Файлы для обучения 
        string s_InputTrainDataFile;
        string s_OutputTrainDataFile;
        // Обучение запущено
        bool b_Run;
        // Мониторинг (остановить мониторинг перед обучением, запустить после обучения)
        Monitoring m_Monitoring;
        // Мониторинг запущен
        bool b_RunMonitoring;

        public SetUpMonitoringToolsForm(MainNeuralNetwork m_MainNet, int i_InputCount, int i_OutputCount, string s_InputTrainDataFile,
            string s_OutputTrainDataFile, Monitoring m_Monitoring)
        {
            InitializeComponent();
            this.m_MainNet = m_MainNet;
            this.i_InputCount = i_InputCount;
            this.i_OutputCount = i_OutputCount;
            this.s_InputTrainDataFile = s_InputTrainDataFile;
            this.s_OutputTrainDataFile = s_OutputTrainDataFile;
            this.m_Monitoring = m_Monitoring;
            b_Run = false;
            b_RunMonitoring = false;
        }

        private void b_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Обучение
        private void b_Train_Click(object sender, EventArgs e)
        {
            if (!b_Run)
            {
                b_Run = true;
                b_RunMonitoring = m_Monitoring.GetRun;
                if (b_RunMonitoring)
                {
                    m_Monitoring.StopMonitoring();
                }
                t_TrainingLog.Text = "Launch neural network training..." + Environment.NewLine;
                // Запуск обучения в отдельном потоке
                Task t_Learning = new Task(new Action(StartLearning));
                t_Learning.Start();
            }
        }

        // Запуск обучения и вывод результатов
        private void StartLearning()
        {
            try
            {
                object o_Errors = m_MainNet.TeacherTraining(i_InputCount, i_OutputCount, s_InputTrainDataFile, s_OutputTrainDataFile);

                c_GraphPerfErrors.Invoke((Action)delegate
                {
                    t_TrainingLog.Text += "Training completed successfully";
                    t_TrainingLog.Text += Environment.NewLine;
                    t_TrainingLog.Text += "Average learning error: " + ((object[])o_Errors)[0].ToString();
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
                c_GraphAbsErrors.Series["Delay time, ms"].Points.Clear();
                    c_GraphAbsErrors.Series["Average transfer speed, bps"].Points.Clear();
                    for (int i = 0; i < d_AbsErrors.GetUpperBound(1) + 1; i++)
                    {
                        c_GraphAbsErrors.Series["Delay time, ms"].Points.AddXY(i, d_AbsErrors[0, i]);
                    }
                    for (int i = 0; i < d_AbsErrors.GetUpperBound(1) + 1; i++)
                    {
                        c_GraphAbsErrors.Series["Average transfer speed, bps"].Points.AddXY(i, d_AbsErrors[1, i]);
                    }
                });
                // Запускаем мониторинг, если он был остановлен
                if (b_RunMonitoring)
                {
                    m_Monitoring.RunMonitoring();
                }
            }
            catch (Exception e_Ex)
            {
                MessageBox.Show("Error code: " + Math.Abs(e_Ex.GetHashCode()) + ". Contact Support.");
            }
            b_Run = false;
        }
    }
}
