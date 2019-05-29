using System;
using System.Windows.Forms;

namespace Ferm
{
    public partial class ViewDB : Form
    {
        public ViewDB()
        {
            InitializeComponent();
        }

        private void configOfCalcBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.configOfCalcBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fermDataBaseDataSet);

        }

        private void ViewDB_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fermDataBaseDataSet.Сattle". При необходимости она может быть перемещена или удалена.
            this.сattleTableAdapter.Fill(this.fermDataBaseDataSet.Сattle);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fermDataBaseDataSet.Strategys". При необходимости она может быть перемещена или удалена.
            this.strategysTableAdapter.Fill(this.fermDataBaseDataSet.Strategys);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fermDataBaseDataSet.Rule". При необходимости она может быть перемещена или удалена.
            this.ruleTableAdapter.Fill(this.fermDataBaseDataSet.Rule);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fermDataBaseDataSet.Market". При необходимости она может быть перемещена или удалена.
            this.marketTableAdapter.Fill(this.fermDataBaseDataSet.Market);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fermDataBaseDataSet.ConfigOfCalc". При необходимости она может быть перемещена или удалена.
            this.configOfCalcTableAdapter.Fill(this.fermDataBaseDataSet.ConfigOfCalc);

        }

        private void bt_ConfigOfCalc_Click(object sender, EventArgs e)
        {
            panel_ConfigOfCalc.Visible = true;
            panel_Market.Visible = false;
            panel_Rule.Visible = false;
            panel_Strategys.Visible = false;
            panel_Cattle.Visible = false;
        }

        private void bt_Market_Click(object sender, EventArgs e)
        {
            panel_Market.Visible = true;
            panel_ConfigOfCalc.Visible = false;
            panel_Rule.Visible = false;
            panel_Strategys.Visible = false;
            panel_Cattle.Visible = false;
        }

        private void bt_Rule_Click(object sender, EventArgs e)
        {
            panel_Rule.Visible = true;
            panel_Market.Visible = false;
            panel_ConfigOfCalc.Visible = false;
            panel_Strategys.Visible = false;
            panel_Cattle.Visible = false;
        }

        private void bt_Strategy_Click(object sender, EventArgs e)
        {
            panel_Strategys.Visible = true;
            panel_Rule.Visible = false;
            panel_Market.Visible = false;
            panel_ConfigOfCalc.Visible = false;
            panel_Cattle.Visible = false;
        }

        private void bt_Cattle_Click(object sender, EventArgs e)
        {
            panel_Cattle.Visible = true;
            panel_Strategys.Visible = false;
            panel_Rule.Visible = false;
            panel_Market.Visible = false;
            panel_ConfigOfCalc.Visible = false;
        }
    }
}
