using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HybridNeuralNetwork
{
    public partial class WaitWindow : Form
    {
        public WaitWindow(string s_Message)
        {
            InitializeComponent();
            l_Message.Text = s_Message;
        }
    }
}
