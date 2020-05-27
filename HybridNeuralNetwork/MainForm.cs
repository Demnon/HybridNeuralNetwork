using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HybridNeuralNetwork
{
    public partial class MainForm : Form
    {
        // Главная сеть
        MainNetwork m_MainNet;
        public MainForm()
        {
            InitializeComponent();

            m_MainNet = new MainNetwork();

            object o_Errors = m_MainNet.TeacherTraining(3, 2, "InputTrainData.txt", "OutputTrainData.txt");
            // 34.6 2905.614
            double[] d_OutputValues = m_MainNet.RunNet(new double[] { 173, 0.9, 10460209 });
        }
    }
}
