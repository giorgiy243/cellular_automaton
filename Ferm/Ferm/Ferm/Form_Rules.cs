using System;
using System.Windows.Forms;

namespace Ferm
{
    public partial class Form_Rules : Form
    {
        public Form_Rules(ref Gamer gamer)
        {
            InitializeComponent();
            ShowRules(ref gamer);
        }

        private void ShowRules(ref Gamer gamer)
        {
            label9.Text = Convert.ToString(gamer.Prcsale1);
            label10.Text = Convert.ToString(gamer.Prcsale2);
            label11.Text = Convert.ToString(gamer.Prcsale3);

            label12.Text = Convert.ToString(gamer.Prccost1);
            label13.Text = Convert.ToString(gamer.Prccost2);
            label14.Text = Convert.ToString(gamer.Prccost3);

            label15.Text = Convert.ToString(gamer.PrSSn1);
            label16.Text = Convert.ToString(gamer.PrSSn2);
            label17.Text = Convert.ToString(gamer.PrSSn3);

            label18.Text = Convert.ToString(gamer.PrSCn1);
            label19.Text = Convert.ToString(gamer.PrSCn2);
            label20.Text = Convert.ToString(gamer.PrSCn3);
        }
    }
}
