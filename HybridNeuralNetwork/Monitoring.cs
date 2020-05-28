using System;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace HybridNeuralNetwork
{
    // Запуск и остановка мониторинга в отдельном потоке, а также выполнение вычислений
    public class Monitoring
    {
        // Поток мониторинга
        Task t_Monitoring;
        // Токен отмены
        CancellationTokenSource c_TokenCancel;
        // Главная нейронная сеть
        MainNeuralNetwork m_MainNeuralNet;
        // Нейросеть из базы знаний
        LayerKnowledgeNet[] l_LayersKnowledgeNet;
        // Таблица
        DataGridView d_InputTable;
        // Панель с выходами
        Control p_NetworkStatusPanel;
        // График
        Chart c_Graph;
        // Выходы гибридной сети
        double[] d_OutputData;
        // Мониторинг запущен
        bool b_Run;
        
        public Monitoring(MainNeuralNetwork m_MainNeuralNet, LayerKnowledgeNet[] l_LayersKnowledgeNet, DataGridView d_InputTable,
            Control p_NetworkStatusPanel, Chart c_Graph)
        {
            this.m_MainNeuralNet = m_MainNeuralNet;
            this.l_LayersKnowledgeNet = l_LayersKnowledgeNet;
            this.d_InputTable = d_InputTable;
            this.p_NetworkStatusPanel = p_NetworkStatusPanel;
            d_OutputData = new double[] { 0, 0, 0 };
            this.c_Graph = c_Graph;
            b_Run = false;
        }

        public bool GetRun
        {
            get { return b_Run; }
        }

        public  double[] GetOutputData
        {
            get { return d_OutputData; }
        }

        // Запуск мониторинга
        public void RunMonitoring()
        {
            c_TokenCancel = new CancellationTokenSource();
            Action a_Action = new Action(MainMethod);
            t_Monitoring = new Task(a_Action);
            t_Monitoring.Start();
            b_Run = true;
         }

        // Остановка мониторинга
        public void StopMonitoring()
        {
            if (t_Monitoring != null)
            {
                c_TokenCancel.Cancel();
                t_Monitoring.Wait();
            }
            // Выключение индикаторов
            d_OutputData = new double[] { 0, 0, 0 };
            GraphicsForObjects.DrawingStatusNetwork(p_NetworkStatusPanel, d_OutputData,
                        new string[] { "Normal work", "Overload", "Failure" }, new Color[] { Color.LawnGreen, Color.Yellow, Color.Red });
            
            b_Run = false;
        }

        // Вычисления, вывод на форму
        private void MainMethod()
        {
            // Журнал мониторинга
            ExcelLog e_Log = new ExcelLog();
            e_Log.ClearLog();

            try
            {
                CancellationToken c_Token = (CancellationToken)c_TokenCancel.Token;               

                // Очистка графика
                c_Graph.Invoke((Action)delegate
                {
                    c_Graph.Series["Values"].Points.Clear();
                });               

                // Цикл мониторинга раз в секунду
                while (!c_Token.IsCancellationRequested)
                {
                    string s_Time = DateTime.Now.ToLongTimeString();
                    // Формирование входных данных для главной нейронной сети
                    double[] d_InputForMainNet = OrganizationInputDataForMainNet(s_Time);                 

                    // Вычисление главной нейронной сети
                    double[] d_OutputValuesInMainNeuralNet = m_MainNeuralNet.RunNet(d_InputForMainNet);

                    // Формирование входных данных для нейронной сети из базы знаний
                    double[] d_InputForKnowledgeNet = OrganizationInputDataForKnowledgeNet(d_OutputValuesInMainNeuralNet);

                    // Вычисление нейронной сети из базы знаний
                    JobKnowledgeNet j_JobKnowledgeNet = new JobKnowledgeNet(l_LayersKnowledgeNet, d_InputForKnowledgeNet);
                    double[] d_OutputValuesInKnowledgeNet = j_JobKnowledgeNet.RunNet();
      
                    // Вывод на индикаторы
                    string s_StatusNetwork = OutputInIndicators(d_OutputValuesInKnowledgeNet);

                    // Вывод в журнал
                    string[] s_NameParameters = new string[d_InputTable.Rows.Count];
                    for (int i = 0; i < s_NameParameters.Length; i++)
                    {
                        s_NameParameters[i] = d_InputTable[0, i].Value.ToString();
                    }
                    e_Log.AddEntryInLog(s_NameParameters, s_Time, d_InputForMainNet, s_StatusNetwork);

                    // Вывод на график
                    OutputInGraph(s_Time);

                    Thread.Sleep(1000);
                }
                
            }
            catch (Exception e_Ex)
            {
                MessageBox.Show("Код ошибки: " + Math.Abs(e_Ex.GetHashCode()) + ", обратитесь в техподдержку.");               
            }

            e_Log.Dispose();
        }

        // Формирование входных данных для главной нейронной сети
        private double[] OrganizationInputDataForMainNet(string s_Time)
        {
            // Рандомные значения для иммитации поступающих данных извне
            Random r_Random = new Random();
            double[] d_InputForMainNet = new double[d_InputTable.Rows.Count];

            for (int i = 0; i < d_InputTable.Rows.Count; i++)
            {
                d_InputTable.Invoke((Action)delegate
                {
                    d_InputTable[1, i].Value = s_Time;
                });
                if (d_InputTable[0, i].Value.ToString() == "Average packet path length, m")
                {
                    d_InputForMainNet[i] = r_Random.Next(100, 200);
                }
                else if (d_InputTable[0, i].Value.ToString() == "Network load, bps")
                {
                    d_InputForMainNet[i] = (double)r_Random.Next(1, 9) / 10;
                }
                else
                {
                    d_InputForMainNet[i] = r_Random.Next(10000000, 11000000);
                }
                d_InputTable.Invoke((Action)delegate
                {
                    d_InputTable[2, i].Value = d_InputForMainNet[i];
                });
            }
            return d_InputForMainNet;
        }

        // Формирование входных данных для нейронной сети из базы знаний
        private double[] OrganizationInputDataForKnowledgeNet(double[] d_OutputValuesInMainNeuralNet)
        {
            double[] d_InputForKnowledgeNet = new double[d_OutputValuesInMainNeuralNet.Length + 1];
            if (l_LayersKnowledgeNet[0].GetSetInputNodes[0].GetLabel == "Среднее время задержки пакетов")
            {
                d_InputForKnowledgeNet[0] = d_OutputValuesInMainNeuralNet[0];
            }
            else
            {
                d_InputForKnowledgeNet[0] = d_OutputValuesInMainNeuralNet[1];
            }
            if (l_LayersKnowledgeNet[0].GetSetInputNodes[1].GetLabel == "Среднее время задержки пакетов")
            {
                d_InputForKnowledgeNet[1] = d_OutputValuesInMainNeuralNet[0];
            }
            else
            {
                d_InputForKnowledgeNet[1] = d_OutputValuesInMainNeuralNet[1];
            }

            d_InputForKnowledgeNet[d_InputForKnowledgeNet.Length - 1] = 1;

            return d_InputForKnowledgeNet;
        }

        // Вывод на индикаторы
        private string OutputInIndicators(double[] d_OutputValuesInKnowledgeNet)
        {
            if (l_LayersKnowledgeNet[l_LayersKnowledgeNet.Length - 1].GetSetOutputNodes[0].GetLabel == "Нормальная работа сети")
            {
                d_OutputData[0] = d_OutputValuesInKnowledgeNet[0];
            }
            else if (l_LayersKnowledgeNet[l_LayersKnowledgeNet.Length - 1].GetSetOutputNodes[0].GetLabel == "Перегрузка сети")
            {
                d_OutputData[1] = d_OutputValuesInKnowledgeNet[0];
            }
            else
            {
                d_OutputData[2] = d_OutputValuesInKnowledgeNet[0];
            }

            if (l_LayersKnowledgeNet[l_LayersKnowledgeNet.Length - 1].GetSetOutputNodes[1].GetLabel == "Нормальная работа сети")
            {
                d_OutputData[0] = d_OutputValuesInKnowledgeNet[1];
            }
            else if (l_LayersKnowledgeNet[l_LayersKnowledgeNet.Length - 1].GetSetOutputNodes[1].GetLabel == "Перегрузка сети")
            {
                d_OutputData[1] = d_OutputValuesInKnowledgeNet[1];
            }
            else
            {
                d_OutputData[2] = d_OutputValuesInKnowledgeNet[1];
            }

            if (l_LayersKnowledgeNet[l_LayersKnowledgeNet.Length - 1].GetSetOutputNodes[2].GetLabel == "Нормальная работа сети")
            {
                d_OutputData[0] = d_OutputValuesInKnowledgeNet[2];
            }
            else if (l_LayersKnowledgeNet[l_LayersKnowledgeNet.Length - 1].GetSetOutputNodes[2].GetLabel == "Перегрузка сети")
            {
                d_OutputData[1] = d_OutputValuesInKnowledgeNet[2];
            }
            else
            {
                d_OutputData[2] = d_OutputValuesInKnowledgeNet[2];
            }

            string s_StatusNetwork = "";
            if (d_OutputData[0] == 1)
            {
                s_StatusNetwork = "Normal work";
            }
            else if (d_OutputData[1] == 1)
            {
                s_StatusNetwork = "Overload";
            }
            else
            {
                s_StatusNetwork = "Failure";
            }

            p_NetworkStatusPanel.Invoke((Action)delegate
            {
                GraphicsForObjects.DrawingStatusNetwork(p_NetworkStatusPanel, d_OutputData,
                new string[] { "Normal work", "Overload", "Failure" }, new Color[] { Color.LawnGreen, Color.Yellow, Color.Red });
            });

            return s_StatusNetwork;
        }
    
        // Вывод на график
        private void OutputInGraph(string s_Time)
        {
            c_Graph.Invoke((Action)delegate
            {
                if (d_OutputData[0] == 1)
                {
                    c_Graph.Series["Values"].Points.AddXY(s_Time, 1);
                }
                else if (d_OutputData[1] == 1)
                {
                    c_Graph.Series["Values"].Points.AddXY(s_Time, 2);
                }
                else
                {
                    c_Graph.Series["Values"].Points.AddXY(s_Time, 3);
                }
            });
        }
    }
}
