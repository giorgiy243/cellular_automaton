using System.Data.SqlClient;

namespace Ferm
{
    class Calc 
    {
        private void WorkWithDataBase_Cattle(ref Gamer gamer, string happened)
        {

            SqlCommand cmd;
            System.IAsyncResult response;

            // Запись в Cattle
            {
                cmd = new SqlCommand("INSERT INTO [dbo].[Сattle] (NumberOfCalc,StepOfCalc," +
                    "Happened,CattleNow_n1,CattleNow_n2,CattleNow_n3)" +

                    "VALUES (@NumberOfCalc,@StepOfCalc,@Happened,@CattleNow_n1," +
                    "@CattleNow_n2,@CattleNow_n3)", gamer.Con);

                cmd.Parameters.AddWithValue("@NumberOfCalc", gamer.identity);
                cmd.Parameters.AddWithValue("@StepOfCalc", gamer.Time - gamer.time);
                cmd.Parameters.AddWithValue("@Happened", happened);
                cmd.Parameters.AddWithValue("@CattleNow_n1", gamer.n1);
                cmd.Parameters.AddWithValue("@CattleNow_n2", gamer.n2);
                cmd.Parameters.AddWithValue("@CattleNow_n3", gamer.n3);

                response = cmd.BeginExecuteNonQuery();
                cmd.EndExecuteNonQuery(response);
            }
        }

        private void WorkWithDataBase_Market(ref Gamer gamer)
        {
            SqlCommand cmd;
            System.IAsyncResult response;

            // Зарись в Cattle
            {
                cmd = new SqlCommand("INSERT INTO [dbo].[Market] (NumberOfCalc,StepOfCalc,SizeOfPay_n1," +
                    "SizeOfPay_n2,SizeOfPay_n3,SizeOfSale_n1,SizeOfSale_n2,SizeOfSale_n3,PriseOfPay_n1," +
                    "PriseOfPay_n2,PriseOfPay_n3,PriseOfSale_n1,PriseOfSale_n2,PriseOfSale_n3)" +

                    "VALUES (@NumberOfCalc,@StepOfCalc,@SizeOfPay_n1," +
                    "@SizeOfPay_n2,@SizeOfPay_n3,@SizeOfSale_n1,@SizeOfSale_n2,@SizeOfSale_n3,@PriseOfPay_n1," +
                    "@PriseOfPay_n2,@PriseOfPay_n3,@PriseOfSale_n1,@PriseOfSale_n2,@PriseOfSale_n3)", gamer.Con);

                cmd.Parameters.AddWithValue("@NumberOfCalc", gamer.identity);
                cmd.Parameters.AddWithValue("@StepOfCalc", gamer.Time - gamer.time);

                cmd.Parameters.AddWithValue("@SizeOfPay_n1", gamer.SCn1); //
                cmd.Parameters.AddWithValue("@SizeOfPay_n2", gamer.SCn2); //кол во на покупку
                cmd.Parameters.AddWithValue("@SizeOfPay_n3", gamer.SCn3); //

                cmd.Parameters.AddWithValue("@SizeOfSale_n1", gamer.SSn1); //
                cmd.Parameters.AddWithValue("@SizeOfSale_n2", gamer.SSn2); // кол-во на продажу
                cmd.Parameters.AddWithValue("@SizeOfSale_n3", gamer.SSn3); //

                cmd.Parameters.AddWithValue("@PriseOfPay_n1", gamer.ccost1); //
                cmd.Parameters.AddWithValue("@PriseOfPay_n2", gamer.ccost2); // Цена покупки
                cmd.Parameters.AddWithValue("@PriseOfPay_n3", gamer.ccost3); //

                cmd.Parameters.AddWithValue("@PriseOfSale_n1", gamer.csale1); //
                cmd.Parameters.AddWithValue("@PriseOfSale_n2", gamer.csale2); // Цена продажи
                cmd.Parameters.AddWithValue("@PriseOfSale_n3", gamer.csale3); //

                response = cmd.BeginExecuteNonQuery();
                cmd.EndExecuteNonQuery(response);
            }
        }

        private void WorkWithDataBase_Rule(ref Gamer gamer)
        {
            SqlCommand cmd;
            System.IAsyncResult response;

            //Запись в Rule
            {
                cmd = new SqlCommand("INSERT INTO [dbo].[Rule] (NumberOfCalc,StepOfCalc,RuleSizeSale_n1,RuleSizeSale_n2," +
                    "RuleSizeSale_n3,RuleSizePay_n1,RuleSizePay_n2,RuleSizePay_n3,RuleOfSale_n1,RuleOfSale_n2," +
                    "RuleOfSale_n3,RuleOfPay_n1,RuleOfPay_n2,RuleOfPay_n3)" +

                    "VALUES (@NumberOfCalc,@StepOfCalc,@RuleSizeSale_n1,@RuleSizeSale_n2," +
                    "@RuleSizeSale_n3,@RuleSizePay_n1,@RuleSizePay_n2,@RuleSizePay_n3,@RuleOfSale_n1,@RuleOfSale_n2," +
                    "@RuleOfSale_n3,@RuleOfPay_n1,@RuleOfPay_n2,@RuleOfPay_n3)", gamer.Con);

                cmd.Parameters.AddWithValue("@NumberOfCalc", gamer.identity);
                cmd.Parameters.AddWithValue("@StepOfCalc", gamer.Time - gamer.time);

                cmd.Parameters.AddWithValue("@RuleSizeSale_n1", gamer.PrSSn1); //
                cmd.Parameters.AddWithValue("@RuleSizeSale_n2", gamer.PrSSn2); // Правило количества поголовья на продажу (Сколько продавать)
                cmd.Parameters.AddWithValue("@RuleSizeSale_n3", gamer.PrSSn3); //

                cmd.Parameters.AddWithValue("@RuleSizePay_n1", gamer.PrSCn1); //
                cmd.Parameters.AddWithValue("@RuleSizePay_n2", gamer.PrSCn2); // Правило количества поголовья на покупку (Сколько плкупать)
                cmd.Parameters.AddWithValue("@RuleSizePay_n3", gamer.PrSCn3); //

                cmd.Parameters.AddWithValue("@RuleOfSale_n1", gamer.Prcsale1); //
                cmd.Parameters.AddWithValue("@RuleOfSale_n2", gamer.Prcsale2); // Правило цены продажи поголовья (За сколько продавать)
                cmd.Parameters.AddWithValue("@RuleOfSale_n3", gamer.Prcsale3); //

                cmd.Parameters.AddWithValue("@RuleOfPay_n1", gamer.Prccost1); //
                cmd.Parameters.AddWithValue("@RuleOfPay_n2", gamer.Prccost2); // Правило цены покупки поголовья  (За сколько покупать)
                cmd.Parameters.AddWithValue("@RuleOfPay_n3", gamer.Prccost3); //

                response = cmd.BeginExecuteNonQuery();
                cmd.EndExecuteNonQuery(response);
            }

        }

        private void WorkWithDataBase_Strategys(ref Gamer gamer, string strategy)
        {
            SqlCommand cmd;
            System.IAsyncResult response;

            // Запись в Strategys
            {
                cmd = new SqlCommand("INSERT INTO [dbo].[Strategys] (NumderOfCalc,NameOfStrategy)" +
                    "VALUES(@NumderOfCalc,@NameOfStrategy)", gamer.Con);

                cmd.Parameters.AddWithValue("@NumderOfCalc", gamer.identity);
                cmd.Parameters.AddWithValue("@NameOfStrategy", strategy);

                response = cmd.BeginExecuteNonQuery();
                cmd.EndExecuteNonQuery(response);
            }
        }

        public void Main(ref Gamer gamer, Form3 f3 = null)
        {
            while (gamer.time > 0)
            {
                // обновление поголовья
                Do.TimeRefresh(ref gamer); // ref позволяет изменить значения в теле вызываемой функции
                if (gamer.ChB_Cattle) { WorkWithDataBase_Cattle(ref gamer, "Time refresh"); } // Запись в DataBase -> Market

                Bazar(ref gamer); // Торги
                if (gamer.ChB_Cattle) { WorkWithDataBase_Cattle(ref gamer, "Shopping"); } // Запись в DataBase -> Market

                // Запись в ф-л
                Do.GetProgress(ref gamer);
                if (f3 != null) f3.CreateGrafhikAktualnost(ref gamer); // График аутуальности

                if (gamer.ChB_Rule) { WorkWithDataBase_Rule(ref gamer); } // Запись в DataBase -> Rule
                if (gamer.ChB_Market) { WorkWithDataBase_Market(ref gamer); } // Запись в DataBase -> Cattle
            }
            gamer.time = gamer.Time;

            if (gamer.ChB_Strategys) { WorkWithDataBase_Strategys(ref gamer, Do.ChooseStrategy()); } // Запись в DataBase -> Strategy
            gamer.NameOfRule = Do.ChooseStrategy();
        }

        // Метод для определения Стоимости поголовья (на покупку / продажу) и кол-ва поголовья (на покупку / продажу)
        private void NewKoofecent(double n, int rule, int up, ref Gamer gamer)
        {
            double[] k;  // число в двоичной СИ

            Do.Rule(rule);  // задаем правило
            Do.TranslateTwo(n, out k);   // перевод числа в двоичную СИ

            if (gamer.Null_boundory) Do.NewSizeKA_null_boundory(k, out k); // получаем новое число в двоичной СИ
            else Do.NewSizeKA_connect_boundory(k, out k);

            Do.TranslateTen(k, up, ref gamer); // новое число в десятичной СИ
        }

        private void Bazar(ref Gamer gamer)
        {
            const int cst1 = 1; // gamer.csale1
            const int cst2 = 2; // gamer.csale2
            const int cst3 = 3; // gamer.csale3

            const int cst4 = 4; // gamer.ccost1
            const int cst5 = 5; // gamer.ccost2
            const int cst6 = 6; // gamer.ccost3

            const int cst7 = 7; // gamer.SSn1
            const int cst8 = 8; // gamer.SSn2   кол-во на продажу
            const int cst9 = 9; // gamer.SSn3

            const int cst10 = 10; // gamer.SSn1
            const int cst11 = 11; // gamer.SSn2   кол-во на покупку
            const int cst12 = 12; // gamer.SSn3


            const int Cst1 = 1; //
            const int Cst2 = 2; // Работа с  1/2/3  типом поголовья 
            const int Cst3 = 3; //


            // Цена продажи (За сколько продавать)
            NewKoofecent(gamer.s1 * 1.2, gamer.Prcsale1, cst1, ref gamer); // коэфициент
            NewKoofecent(gamer.s2 * 1.2, gamer.Prcsale2, cst2, ref gamer); // для 
            NewKoofecent(gamer.s3 * 1.2, gamer.Prcsale3, cst3, ref gamer); // продажи

            // Цена покупки (За сколько покупать)
            NewKoofecent((gamer.s1 * 0.8), gamer.Prccost1, cst4, ref gamer); // коэфициент
            NewKoofecent((gamer.s2 * 0.8), gamer.Prccost2, cst5, ref gamer); // для 
            NewKoofecent((gamer.s3 * 0.8), gamer.Prccost3, cst6, ref gamer); // покупки

            // Кол-во на продажу (Сколько продавать)
            NewKoofecent((gamer.n1 * gamer.csale1), gamer.PrSSn1, cst7, ref gamer);
            NewKoofecent((gamer.n2 * gamer.csale2), gamer.PrSSn2, cst8, ref gamer); 
            NewKoofecent((gamer.n3 * gamer.csale3), gamer.PrSSn3, cst9, ref gamer);

            // Кол-во на покупку (Сколько покупать)
            NewKoofecent((gamer.mony - (gamer.n1 * gamer.ccost1)), gamer.PrSCn1, cst10, ref gamer);
            NewKoofecent((gamer.mony - (gamer.n2 * gamer.ccost2)), gamer.PrSCn2, cst11, ref gamer);
            NewKoofecent((gamer.mony - (gamer.n3 * gamer.ccost3)), gamer.PrSCn3, cst12, ref gamer);

            // Продажа
            Do.Prodaga(gamer.SSn1, Cst1, ref gamer);
            Do.Prodaga(gamer.SSn2, Cst2, ref gamer);
            Do.Prodaga(gamer.SSn3, Cst3, ref gamer);

            // Покупка
            Do.Pokypka(gamer.SCn1, Cst1, ref gamer);
            Do.Pokypka(gamer.SCn2, Cst2, ref gamer);
            Do.Pokypka(gamer.SCn3, Cst3, ref gamer);
        }
    }
}
