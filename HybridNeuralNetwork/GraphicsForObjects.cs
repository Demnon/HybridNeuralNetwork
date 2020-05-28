using System;
using System.Drawing;
using System.Windows.Forms;

namespace HybridNeuralNetwork
{
    // Работа с графикой на визуальных объектах
    public static class GraphicsForObjects
    {
        // Рисование состояния мониторинга (запущен, остановлен)
        public static void DrawingStatusMonitoring(Control c_Object, bool b_Run)
        {
            // Графика для объекта
            Graphics g_Graphics = c_Object.CreateGraphics();
            // Очистка графики перед рисованием
            g_Graphics.Clear(Color.White);
            // Получение координат для рисования и рисование
            int i_Radius = 20;
            int i_Y = c_Object.Height / 2;
            int i_X = c_Object.Width - 20;
            if (b_Run)
            {
                g_Graphics.FillEllipse(new SolidBrush(Color.LawnGreen), i_X - i_Radius / 2, i_Y - i_Radius / 2, i_Radius, i_Radius);
            }
            else
            {
                g_Graphics.FillEllipse(new SolidBrush(Color.Gray), i_X - i_Radius / 2, i_Y - i_Radius / 2, i_Radius, i_Radius);
                
            }
        }

        // Рисование состояния сети на заданном объекте для заданных значений
        public static void DrawingStatusNetwork(Control c_Object, double[] d_ValueOutput, string[] s_NameOutput,Color[] c_Colors)
        {
            if (d_ValueOutput.Length!=s_NameOutput.Length||c_Colors.Length!=d_ValueOutput.Length)
            {
                throw new ApplicationException("Enter the same number of parameter names and their values.");
            }        

            // Графика для объекта
            Graphics g_Graphics = c_Object.CreateGraphics();
            // Очистка графики перед рисованием
            g_Graphics.Clear(Color.FromArgb(214, 241, 250));
            // Получение координат для рисования и рисование
            int i_Radius = 50;
            int i_Y = c_Object.Height / 2;
            int[] i_X = new int[d_ValueOutput.Length];
            for (int i=0;i<i_X.Length;i++)
            {              
                i_X[i] = Convert.ToInt32(c_Object.Width * ((double)(i + 1) / (i_X.Length + 1)));
                // Рисование, если активный выход, то цветной круг, иначе серый
                if (d_ValueOutput[i] == 0)
                {
                    g_Graphics.FillEllipse(new SolidBrush(Color.Gray), i_X[i] - i_Radius/2, i_Y - i_Radius/2, i_Radius, i_Radius);
                }
                else
                {
                    g_Graphics.FillEllipse(new SolidBrush(c_Colors[i]), i_X[i] - i_Radius/2, i_Y - i_Radius/2, i_Radius, i_Radius);
                }
                // Рисование label
                // Если данная подпись уже была, то меняем ее местоположение
                Control[] c_FindLabel = c_Object.Controls.Find("l_" + s_NameOutput[i], true);
                if (c_FindLabel.Length > 0)
                {
                    c_FindLabel[0].Location = new Point(i_X[i] - (c_FindLabel[0].Width / 2), i_Y + i_Radius/2 + c_FindLabel[0].Height / 2);
                }
                // Иначе создаем новый label
                else
                {
                    Label l_Label = new Label();
                    c_Object.Controls.Add(l_Label);
                    l_Label.BackColor = Color.FromArgb(214, 241, 250);
                    l_Label.Font = new Font("Times New Roman", 12F);
                    l_Label.ForeColor = Color.Black;

                    l_Label.Name = "l_" + s_NameOutput[i];
                    l_Label.AutoSize = true;
                    l_Label.Text = s_NameOutput[i];
                    l_Label.TextAlign = ContentAlignment.MiddleCenter;
                    l_Label.Location = new Point(i_X[i] - (l_Label.Width / 2), i_Y + i_Radius/2 + l_Label.Height / 2);
                }
            }

            
        }
    }
}
