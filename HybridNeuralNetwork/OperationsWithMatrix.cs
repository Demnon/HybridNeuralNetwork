using System;

namespace HybridNeuralNetwork
{
    // Класс работы с матрицами
    public static class OperationsWithMatrix
    {
        // Добавление смещения в вектор
        public static double[] AddOffsetVector(double[] d_Vector)
        {
            double[] d_OutVector = new double[d_Vector.Length + 1];
            for (int i=0;i<d_Vector.Length;i++)
            {
                d_OutVector[i] = d_Vector[i];
            }
            d_OutVector[d_OutVector.Length - 1] = 1;

            return d_OutVector;
        }
        //Перемножение вектора на матрицу (после перемножения - матрица)
        public static double[] MultipleVectorOnMatrix(double[] d_Vector, double[,] d_Matrix)
        {
            double[] d_OutVector = new double[d_Matrix.GetUpperBound(1) + 1];
            for (int i = 0; i < d_Matrix.GetUpperBound(1) + 1; i++)
            {
                for (int j = 0; j < d_Vector.Length; j++)
                {
                    d_OutVector[i] += d_Vector[j] * d_Matrix[j, i];
                }
            }
            return d_OutVector;
        }

        // Прогон вектора через функцию активации
        public static void ActivationVector(double[] d_Vector)
        {
            for (int i = 0; i < d_Vector.Length; i++)
            {
                d_Vector[i] = d_Vector[i] > 0 ? 1 : 0;
            }
        }

        // Получение матрицы весов
        public static double[,] GetMatrixWeight(NodeKnowledgeNet[] n_InputNodes, NodeKnowledgeNet[] n_OutputNodes)
        {
            // Объявление матрицы нужной размерности
            double[,] d_Matrix = new double[n_InputNodes.Length + 1, n_OutputNodes.Length];
            for (int j = 0; j < n_OutputNodes.Length; j++)
            {
                for (int i = 0; i < n_InputNodes.Length; i++)
                {
                    d_Matrix[i, j] = GetWeight(n_InputNodes[i].GetName, n_OutputNodes[j]);
                }
                d_Matrix[n_InputNodes.Length, j] = GetOffset(n_OutputNodes[j]);
            }

            return d_Matrix;
        }

        // Получение конкретного веса
        private static double GetWeight(string s_InputName, NodeKnowledgeNet n_Node)
        {
            double d_Weight = 0;
            string s_Name = Array.Find(n_Node.GetNamesLinkedNodes, x => x == s_InputName);
            if (s_Name != null)
            {
                switch (n_Node.GetNameOperator)
                {
                    case "ins:less":
                        d_Weight = -1;
                        break;
                    case "ins:more":
                        d_Weight = 1;       
                        break;
                    case "ins:or":
                        d_Weight = 1;
                        break;
                    case "ins:and":
                        d_Weight = 1;
                        break;
                    case "ins:equal":
                        d_Weight = -1;
                        break;
                    default:
                        d_Weight = 0;
                        break;
                }
            }
            return d_Weight;
        }

        // Получение конкретного смещения
        private static double GetOffset(NodeKnowledgeNet n_Node)
        {
            double d_Offset;
            switch (n_Node.GetNameOperator)
            {
                case "ins:less":
                    d_Offset = n_Node.GetValue;
                    break;
                case "ins:more":
                    d_Offset = -n_Node.GetValue;
                    break;
                case "ins:or":
                    d_Offset = -0.5;
                    break;
                case "ins:and":
                    d_Offset = -n_Node.GetNamesLinkedNodes.Length + 0.5;
                    break;
                case "ins:equal":
                    d_Offset = 0.5;
                    break;
                default:
                    d_Offset = 0;
                    break;
            }
            return d_Offset;
        }
    }
}
