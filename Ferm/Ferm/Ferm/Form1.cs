using System;
using System.Windows.Forms;

namespace Ferm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
        }
    }
}
