using System;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Ferm
{

    public partial class Main : Form
    {
        Gamer gamer;
        Calc calc;
        private int chooze;

        public Main()
        {
            InitializeComponent();
            gamer = new Gamer();
            gamer.Null_boundory = true;
            gamer.Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Egor\Desktop\Ferm\Ferm\Ferm\FermDataBase.mdf;Integrated Security=True");
            gamer.Con.Open();
            calc = new Calc();
        }

        private void ShowOptions(bool p)
        {
            panel_Cascad.Visible = p;
        }

        private void ShowGetDate(bool p)
        {
            bt_Old.Visible = p;
            bt_Young.Visible = p;
            bt_Teen.Visible = p;
            btRules.Visible = p;
        }

        private void ShowGetOptions(bool p)
        {
            panel1.Visible = p;
            panel2.Visible = p;
            panel3.Visible = p;
            panel4.Visible = p;
            panel5.Visible = p;
            panel6.Visible = p;

            label2.Visible = p;
            label3.Visible = p;
            label4.Visible = p;
            label6.Visible = p;
            label7.Visible = p;
            label8.Visible = p;
            label9.Visible = p;
            label10.Visible = p;
            label11.Visible = p;
            label12.Visible = p;

            numericUpDown2.Visible = p;
            numericUpDown3.Visible = p;
            numericUpDown4.Visible = p;
            numericUpDown5.Visible = p;
            numericUpDown6.Visible = p;
            numericUpDown7.Visible = p;

            bt_enter.Visible = p;
            btRules.Visible = p;
        }

        private void ShowGetSize(bool p)
        {
            btRules.Visible = p;

            panel7.Visible = p;
            panel8.Visible = p;
            panel9.Visible = p;

            label13.Visible = p;
            label14.Visible = p;
            label15.Visible = p;
            label16.Visible = p;
            label17.Visible = p;
            label18.Visible = p;
            label19.Visible = p;
            label20.Visible = p;
            label21.Visible = p;
            label22.Visible = p;
            label23.Visible = p;
            label24.Visible = p;
            label25.Visible = p;
            label26.Visible = p;
            label27.Visible = p;
            label28.Visible = p;
            label29.Visible = p;
            label30.Visible = p;
            label31.Visible = p;
            label32.Visible = p;
            label33.Visible = p;
            label34.Visible = p;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowGetDate(false);
            ShowGetOptions(false);
            ShowGetSize(false);
            ShowOptions(true);
        }

        private void главнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowOptions(false);
            ShowGetDate(false);
            ShowGetOptions(false);
            ShowGetSize(false);
        }

        private void посмотретьЗначенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowOptions(false);
            ShowGetDate(false);
            ShowGetOptions(false);
            ShowGetSize(true);
            GetUpdateSize();
        }

        private void задатьЗначенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowGetDate(true);
            ShowOptions(false);
            ShowGetOptions(false);
            ShowGetSize(false);
        }

        private void bt_Young_Click(object sender, EventArgs e)
        {
            label7.Text = "Молодняк";
            ShowGetOptions(true);
            ShowGetDate(false);
            ShowOptions(false);
            chooze = 1;
        }

        private void bt_Teen_Click(object sender, EventArgs e)
        {
            label7.Text = "Зрелые";
            ShowGetOptions(true);
            ShowGetDate(false);
            ShowOptions(false);
            chooze = 2;
        }

        private void bt_Old_Click(object sender, EventArgs e)
        {
            label7.Text = "Старые";
            ShowGetOptions(true);
            ShowGetDate(false);
            ShowOptions(false);
            chooze = 3;
        }

        // Кнопка "Запомнить"
        private void button1_Click(object sender, EventArgs e)
        {
            if (chooze == 1)
            {
                gamer.N1 = Convert.ToInt32(numericUpDown2.Value);
                gamer.n1 = gamer.N1;
                gamer.s1 = Convert.ToInt32(numericUpDown3.Value);
                gamer.Mony = Convert.ToInt32(numericUpDown4.Value);
                gamer.mony = gamer.Mony;
                gamer.time = Convert.ToInt16(numericUpDown5.Value);
                gamer.Time = Convert.ToInt16(numericUpDown5.Value);
                gamer.dn1 = Convert.ToDouble(numericUpDown7.Value);
                gamer.dn1 = gamer.dn1 / 100 + 1;

                gamer.rule = Convert.ToInt16(numericUpDown6.Value);
                gamer.PrSSn1 = gamer.rule;
                gamer.PrSCn1 = gamer.rule;
                gamer.Prcsale1 = gamer.rule;
                gamer.Prccost1 = gamer.rule;

                задатьЗначенияToolStripMenuItem_Click(sender, e);
            }
            if (chooze == 2)
            {
                gamer.N2 = Convert.ToInt32(numericUpDown2.Value);
                gamer.n2 = gamer.N2;
                gamer.s2 = Convert.ToInt32(numericUpDown3.Value);
                gamer.Mony = Convert.ToInt32(numericUpDown4.Value);
                gamer.mony = gamer.Mony;
                gamer.time = Convert.ToInt16(numericUpDown5.Value);
                gamer.Time = Convert.ToInt16(numericUpDown5.Value);
                gamer.dn2 = Convert.ToDouble(numericUpDown7.Value);
                gamer.dn2 = gamer.dn2 / 100 + 1;

                gamer.rule = Convert.ToInt16(numericUpDown6.Value);
                gamer.PrSSn2 = gamer.rule;
                gamer.PrSCn2 = gamer.rule;
                gamer.Prcsale2 = gamer.rule;
                gamer.Prccost2 = gamer.rule;

                задатьЗначенияToolStripMenuItem_Click(sender, e);
            }
            if (chooze == 3)
            {
                gamer.N3 = Convert.ToInt32(numericUpDown2.Value);
                gamer.n3 = gamer.N3;
                gamer.s3 = Convert.ToInt32(numericUpDown3.Value);
                gamer.Mony = Convert.ToInt32(numericUpDown4.Value);
                gamer.mony = gamer.Mony;
                gamer.time = Convert.ToInt16(numericUpDown5.Value);
                gamer.Time = Convert.ToInt16(numericUpDown5.Value);
                gamer.dn3 = Convert.ToDouble(numericUpDown7.Value);
                gamer.dn3 = gamer.dn3 / 100 + 1;

                gamer.rule = Convert.ToInt16(numericUpDown6.Value);
                gamer.PrSSn3 = gamer.rule;
                gamer.PrSCn3 = gamer.rule;
                gamer.Prcsale3 = gamer.rule;
                gamer.Prccost3 = gamer.rule;

                задатьЗначенияToolStripMenuItem_Click(sender, e);
            }
        }

        // Обнавляет отображение сохраненных значений
        private void GetUpdateSize()
        {
            label22.Text = Convert.ToString(gamer.N1);
            label28.Text = Convert.ToString(gamer.N2); // Количество поголовья
            label25.Text = Convert.ToString(gamer.N3);

            label23.Text = Convert.ToString(gamer.s1);
            label30.Text = Convert.ToString(gamer.s2); // Стоимость содержания
            label26.Text = Convert.ToString(gamer.s3);

            label24.Text = Convert.ToString(gamer.dn1);
            label29.Text = Convert.ToString(gamer.dn2); // % Прироста
            label27.Text = Convert.ToString(gamer.dn3);

            label32.Text = Convert.ToString(gamer.Mony);
            label34.Text = Convert.ToString(gamer.time);
        }

        // Финансы
        private void финансыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void актуальностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            calc.Main(ref gamer, f3);
            f3.Show();
        }

        private void эталонToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        // "Узнать стратегию"
        private void узнатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int delta = Convert.ToInt32(numericUpDown8.Value);
            Do.GetStrategyByFile(openFileDialog1, delta);
        }

        private void WorkWithDataBase_ConfigOfCalc()
        {
            SqlCommand cmd;

            // Запись в ConfigOfCalc
            {
                cmd = new SqlCommand("INSERT INTO ConfigOfCalc (TimeOfEnd,MonyBegin,Прирост_N1,Прирост_N2," +
                    "Прирост_N3,Количество_N1,Количество_N2,Количество_N3,Содержание_N1,Содержание_N2,Содержание_N3)" +

                    "VALUES (@TimeOfEnd,@MonyBegin,@Прирост_N1,@Прирост_N2,@Прирост_N3,@Количество_N1,@Количество_N2," +
                    "@Количество_N3,@Содержание_N1,@Содержание_N2,@Содержание_N3)", gamer.Con);

                cmd.Parameters.AddWithValue("@TimeOfEnd", gamer.Time);
                cmd.Parameters.AddWithValue("@MonyBegin", gamer.Mony);
                cmd.Parameters.AddWithValue("@Прирост_N1", gamer.dn1);
                cmd.Parameters.AddWithValue("@Прирост_N2", gamer.dn2);
                cmd.Parameters.AddWithValue("@Прирост_N3", gamer.dn3);
                cmd.Parameters.AddWithValue("@Количество_N1", gamer.N1);
                cmd.Parameters.AddWithValue("@Количество_N2", gamer.N2);
                cmd.Parameters.AddWithValue("@Количество_N3", gamer.N3);
                cmd.Parameters.AddWithValue("@Содержание_N1", gamer.s1);
                cmd.Parameters.AddWithValue("@Содержание_N2", gamer.s2);
                cmd.Parameters.AddWithValue("@Содержание_N3", gamer.s3);

                System.IAsyncResult response = cmd.BeginExecuteNonQuery();
                cmd.EndExecuteNonQuery(response);

                cmd = new SqlCommand("SELECT @@IDENTITY", gamer.Con);
                gamer.identity = Convert.ToDouble(cmd.ExecuteScalar());
            }

        }

        private void запуститьРасчётToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gamer.ChB_ConfigOfCalcs) { WorkWithDataBase_ConfigOfCalc(); }
            calc.Main(ref gamer);
        }

        private void каскадныеВычисленияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (chbCascad.Checked == true)
            {
                for (int i = Convert.ToInt32(udMore_Pay.Value); i < ud_Pay.Value; i++)
                {
                    for (int a = Convert.ToInt32(udMore_SizeOfPay.Value); a < ud_SizeOfPay.Value; a++)
                    {
                        gamer.n1 = gamer.N1;
                        gamer.n2 = gamer.N2;
                        gamer.n3 = gamer.N3;
                        gamer.mony = gamer.Mony;

                        gamer.PrSSn1 = a; //
                        gamer.PrSSn2 = a; // Правило количества поголовья на продажу (Сколько продавать)
                        gamer.PrSSn3 = a; //

                        gamer.PrSCn1 = a; //
                        gamer.PrSCn2 = a; // Количество поголовья на покупку (Скольео покупать)
                        gamer.PrSCn3 = a; //

                        gamer.Prcsale1 = i; //
                        gamer.Prcsale2 = i; // Правило цены продажи поголовья (За сколько продавать)
                        gamer.Prcsale3 = i; //

                        gamer.Prccost1 = i; //
                        gamer.Prccost2 = i; // Правило цены покупки поголовья  (За сколько покупать) 
                        gamer.Prccost3 = i; //

                        if (gamer.ChB_Cattle) { WorkWithDataBase_ConfigOfCalc(); }    // запускаем
                        calc.Main(ref gamer);                                         // расчеты
                    }
                }
            }
            else { MessageBox.Show("Установите настройки каскадного вычисления !"); }

            MessageBox.Show("Вычисления окончены");
        }

        // Просмотр правил игры
        private void btRules_Click(object sender, EventArgs e)
        {
            Form_Rules frules = new Form_Rules(ref gamer);
            frules.Show();
        }

        private void базаРасчетовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewDB Vdb = new ViewDB();
            Vdb.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool sw = More1.Visible;
            sw = (!sw);

            More1.Visible = sw;
            More5.Visible = sw;
            More6.Visible = sw;

            udMore_Pay.Visible = sw;
            udMore_SizeOfPay.Visible = sw;
        }

        private void каскадныеВычисленияотождествлениеГраницToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gamer.Null_boundory = false;

            for (int i = 0; i < 256; i++)
            {
                gamer.n1 = gamer.N1;
                gamer.n2 = gamer.N2;
                gamer.n3 = gamer.N3;
                gamer.mony = gamer.Mony;

                gamer.PrSSn1 = i; //
                gamer.PrSSn2 = i; // Правило количества поголовья на продажу (Сколько продавать)
                gamer.PrSSn3 = i; //

                gamer.PrSCn1 = i; //
                gamer.PrSCn2 = i; // Количество поголовья на покупку (Скольео покупать)
                gamer.PrSCn3 = i; //

                gamer.Prcsale1 = i; //
                gamer.Prcsale2 = i; // Правило цены продажи поголовья (За сколько продавать)
                gamer.Prcsale3 = i; //

                gamer.Prccost1 = i; //
                gamer.Prccost2 = i; // Правило цены покупки поголовья  (За сколько покупать) 
                gamer.Prccost3 = i; //

                if (gamer.ChB_Cattle) { WorkWithDataBase_ConfigOfCalc(); }   // запускаем
                calc.Main(ref gamer);                                        // расчеты
            }

            gamer.Null_boundory = true;
            MessageBox.Show("Вычисления окончены");
        }

        private void bt_SaveOptions_Click(object sender, EventArgs e)
        {
            gamer.ChB_Cattle = Convert.ToBoolean(chB_Cattle.Checked);
            gamer.ChB_ConfigOfCalcs = Convert.ToBoolean(chB_ConfigOfCalc.Checked);
            gamer.ChB_Market = Convert.ToBoolean(chB_Market.Checked);
            gamer.ChB_Rule = Convert.ToBoolean(chB_Rule.Checked);
            gamer.ChB_Strategys = Convert.ToBoolean(chB_Strategys.Checked);
        }
    }
}
