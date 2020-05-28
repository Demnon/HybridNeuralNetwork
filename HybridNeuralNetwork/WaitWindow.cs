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
