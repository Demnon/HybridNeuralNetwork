using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ApproximationNetworkNative;
using System.IO;

namespace HybridNeuralNetwork
{
    // Работа с главной нейронной сетью, которая обучается на входных данных и выдает конкретные значения скорости и времени задержки
    class MainNetwork
    {
        Network n_Net;
        public MainNetwork()
        {
            n_Net = new Network();
        }

        // Метод обучения c учителем,входные параметры - число входов и выходов, выходной параметр - значения ошибок
        public object TeacherTraining(int i_InputCount, int i_OutputCount, string s_FileInputTrainData, string s_FileOutputTrainData)
        {
            // Обучение
            object[] o_Errors = n_Net.CreateAndTrainingNet(3,(object)i_InputCount, (object)i_OutputCount,
                (object)s_FileInputTrainData,
                (object)s_FileOutputTrainData);
            // Средняя ошибка
            double d_Performance = GetSignificationDigit(2,((double[,])o_Errors[0])[0, 0]);

            // Ошибка обучения
            double[,] d_HelpArray = (double[,])o_Errors[1];      
            double[] d_PerfErrors = new double[d_HelpArray.GetUpperBound(1) + 1];
            for (int i=0;i<d_PerfErrors.Length;i++)
            {
                d_PerfErrors[i] = d_HelpArray[0, i];
            }

            // Ошибка после обучения
            double[,] d_AbsErrors = ((double[,])o_Errors[2]);

            return new object[] { d_Performance, d_PerfErrors, d_AbsErrors };
        }

        // Выполнение сети, входной параметр - массив входных значений, выходной параметр - массив выходных значений
        public double[] RunNet(double[] d_InputValues)
        {
            object o_Res = n_Net.RunNet((object)d_InputValues);
            double[,] d_Res = (double[,])o_Res;
            double[] d_OutputValues = new double[d_Res.GetUpperBound(1)+1];
            for (int i=0;i<d_Res.GetUpperBound(1)+1;i++)
            {
                d_OutputValues[i] = Math.Round(d_Res[0, i],2);
            }
            return d_OutputValues;
        }

        // Округление числа до заданного количества значащих цифр
        private double GetSignificationDigit(int i_Digits, double d_Number)
        {
            double d_Result=0;
            //Порядок числа
            int i_MagnitudeOfNumber = (int)Math.Floor(Math.Log10(d_Number));
            //Общее количество десятичных разрядов
            int i_NumberOfDigits = (int)Math.Ceiling(Math.Log10(d_Number));
            if (i_NumberOfDigits == i_Digits)
            {
                //Если количество разрядов равно количеству значащих цифр
                d_Result = d_Number;
            }
            else
            {
                //Если нет
                double d_P = Math.Pow(10, i_MagnitudeOfNumber);
                double d_D = Math.Pow(10, i_Digits - 1);
                d_Result = d_Number / d_P;
                d_Result = (Math.Round(d_Result * d_D) / d_D) * d_P;
            }
            return d_Result;
        }

    }
}
