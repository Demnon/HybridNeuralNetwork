
namespace HybridNeuralNetwork
{
    // Работа сети из базы знаний
    class JobKnowledgeNet
    {
        // Готовые слои сети
        LayerKnowledgeNet[] l_LayersNet;

        // 2 аргумент - входные данные для сети
        public JobKnowledgeNet(LayerKnowledgeNet[] l_LayersNet, double[] d_InputData)
        {
            this.l_LayersNet = l_LayersNet;
            // Заполнение входных данных для сети
            l_LayersNet[0].GetSetInputVector = d_InputData;
        }

        // Запуск работы сети, получение выходных данных
        public double[] RunNet()
        {
            double[] d_OutputData = null;
            // Выполнение операций последовательно для каждого слоя
            for (int i=0;i<l_LayersNet.Length;i++)
            {
                // Умножение входного вектора на матрицу весов и запись результата в выходной вектор
                l_LayersNet[i].GetSetOutputVector = OperationsWithMatrix.MultipleVectorOnMatrix(l_LayersNet[i].GetSetInputVector, l_LayersNet[i].GetSetMatrixWeights);
                // Прогон выходного вектора через функцию активации
                OperationsWithMatrix.ActivationVector(l_LayersNet[i].GetSetOutputVector);
                // Если еще слой, то передача ему выходного вектора, иначе передача на выход
                if (i==l_LayersNet.Length-1)
                {
                    d_OutputData = l_LayersNet[i].GetSetOutputVector;
                }
                else
                {
                    // Добавление смещения к вектору
                    l_LayersNet[i].GetSetOutputVector = OperationsWithMatrix.AddOffsetVector(l_LayersNet[i].GetSetOutputVector);
                    l_LayersNet[i + 1].GetSetInputVector = l_LayersNet[i].GetSetOutputVector;
                }
            }

            return d_OutputData;
        }
    }
}
