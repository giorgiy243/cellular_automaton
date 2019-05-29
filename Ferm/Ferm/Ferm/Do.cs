using System;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;


public struct Gamer
{
    private static SqlConnection _con;
    public SqlConnection Con
    {
        get { return _con; }
        set
        {
            if (_con == null)
            {
                _con = value;
            } } }       // Строка подключения
    public double identity { get; set; } //идентификатор расчета
    public Int16 rule { get; set; } // Правило КА
    public string NameOfRule { get; set; } // Название правила

    public bool Null_boundory { get; set; } // Подсчет с нулевыми границами

    public bool ChB_ConfigOfCalcs { get; set; }
    public bool ChB_Market { get; set; }
    public bool ChB_Rule { get; set; }
    public bool ChB_Strategys { get; set; }
    public bool ChB_Cattle { get; set; }

    public double N1 { get; set; }
    public double N2 { get; set; }// Начальное количество поголовья
    public double N3 { get; set; }

    public double n1 { get; set; }
    public double n2 { get; set; } // Количество поголовья в текущий момент
    public double n3 { get; set; }

    public double SSn1 { get; set; }
    public double SSn2 { get; set; } // Количество поголовья на продажу
    public double SSn3 { get; set; }

    public int PrSSn1 { get; set; }
    public int PrSSn2 { get; set; } // Правило количества поголовья на продажу (Сколько продавать)
    public int PrSSn3 { get; set; }

    public double SCn1 { get; set; }
    public double SCn2 { get; set; } // Количество поголовья на покупку
    public double SCn3 { get; set; }

    public int PrSCn1 { get; set; }
    public int PrSCn2 { get; set; } // Правило количества поголовья на покупку (Сколько плкупать)
    public int PrSCn3 { get; set; }

    public int s1 { get; set; }
    public int s2 { get; set; } // Стоимость содержания
    public int s3 { get; set; }

    public double Mony { get; set; } // Количество деген в начальный момент
    public double mony { get; set; } // Количество денег в текущий момент   
    public Int16 time { get; set; } // Время до конца расчёта
    public Int16 Time { get; set; } // Время расчёта

    public double csale1 { get; set; }
    public double csale2 { get; set; } // Цена продажи поголовья
    public double csale3 { get; set; }

    public int Prcsale1 { get; set; }
    public int Prcsale2 { get; set; } // Правило цены продажи поголовья (За сколько продавать)
    public int Prcsale3 { get; set; }

    public double ccost1 { get; set; }
    public double ccost2 { get; set; } // Цена покупки поголовья 
    public double ccost3 { get; set; }

    public int Prccost1 { get; set; }
    public int Prccost2 { get; set; } // Правило цены покупки поголовья  (За сколько покупать)
    public int Prccost3 { get; set; }

    public double dn1 { get; set; }
    public double dn2 { get; set; } // Коэф-ты прироста поголовья
    public double dn3 { get; set; }
}


namespace Ferm
{
    public static class Do
    {
        private static int[] rule = { 0, 0, 0, 0, 0, 0, 0, 0 }; // Правило перевода

        private static double[] n1 = null;
        private static double[] n2;
        private static double[] n3;
        private static double[] mony;


        // Опрееление правила перехода
        public static void Rule(int chislo)
        {
            int p = chislo;
            int i = 0;

            // Количество значемых цыфр в двоичной форме записи
            while (p > 0)
            {
                p = p / 2;
                i++;
            }

            p = chislo;

            for (int g = 8; g > 8 - i; g--)
            {
                rule[g - 1] = p % 2;
                p = p / 2;
            }
        }

        // Перевод в двоичную СО
        public static void TranslateTwo(double chislo, out double[] d)
        {
            double p = chislo;
            int i = 0;

            // Количество значемых цыфр в двоичной форме записи
            while (p > 0)
            {
                p = p / 2;
                i++;
            }

            int buf = i;
            if ((i % 4) != 0)
            {
                do
                {
                    i++;
                } while ((i % 4) != 0);
            }

            d = new double[i];
            p = chislo;

            for (int g = i; g > 0; g--)
            {
                d[g - 1] = p % 2;
                p = p / 2;
            }


        }

        // Перевод в десятичную СО
        public static void TranslateTen(double[] ir, int up, ref Gamer gamer)
        {
            //otv = 0;
            switch (up)
            {
                case 1: { gamer.csale1 = 0; break; }
                case 2: { gamer.csale2 = 0; break; }
                case 3: { gamer.csale3 = 0; break; }
                case 4: { gamer.ccost1 = 0; break; }
                case 5: { gamer.ccost2 = 0; break; }
                case 6: { gamer.ccost3 = 0; break; }

                case 7: { gamer.SSn1 = 0; break; } //
                case 8: { gamer.SSn2 = 0; break; } // кол-во на продажу
                case 9: { gamer.SSn3 = 0; break; } //

                case 10: { gamer.SCn1 = 0; break; } //
                case 11: { gamer.SCn2 = 0; break; } // кол-во на покупку
                case 12: { gamer.SCn3 = 0; break; } //
            }

            // перевод в десятичную СИ и запись в переменную
            for (int i = 0; i < ir.Length; i++)
            {
                int d = 1;
                for (int f = 0; f < ir.Length - 1 - i; f++)
                {
                    d *= 2;
                }

                switch (up)
                {
                    case 1: { gamer.csale1 += ir[i] * d; break; }
                    case 2: { gamer.csale2 += ir[i] * d; break; }
                    case 3: { gamer.csale3 += ir[i] * d; break; }
                    case 4: { gamer.ccost1 += ir[i] * d; break; }
                    case 5: { gamer.ccost2 += ir[i] * d; break; }
                    case 6: { gamer.ccost3 += ir[i] * d; break; }

                    case 7: { gamer.SSn1 += ir[i] * d; break; }
                    case 8: { gamer.SSn2 += ir[i] * d; break; }
                    case 9: { gamer.SSn3 += ir[i] * d; break; }

                    case 10: { gamer.SCn1 += ir[i] * d; break; }
                    case 11: { gamer.SCn2 += ir[i] * d; break; }
                    case 12: { gamer.SCn3 += ir[i] * d; break; }
                }
            }
        }

        // Печать в ф-л Итог
        private static void Print(int chislo, int rule)
        {
            StreamWriter sw = File.AppendText(Path.Combine(Application.StartupPath, "Итог" +
                Convert.ToString(rule) + ".csv"));

            sw.Write(Convert.ToString(chislo));

            sw.WriteLine("");
            sw.Close();
        }

        public static void PrintStrategy(ref Gamer gamer)
        {
            StreamWriter sw = File.AppendText(Path.Combine(Application.StartupPath, "Strategys" + ".csv"));

            if (gamer.NameOfRule == "Разорение") { sw.Write("Bankruptcise;"); }
            if (gamer.NameOfRule == "Рост 'молодняк'") { sw.Write("Increment 'junior';'"); }
            if (gamer.NameOfRule == "Рост 'зрелые'") { sw.Write("Increment 'midly'" + ';'); }
            if (gamer.NameOfRule == "Рост 'старые'") { sw.Write("Increment 'old'" + ';'); }
            if (gamer.NameOfRule == "Рост поголовья и прибыли") { sw.Write("Increment cattle and cash" + ';'); }
            if (gamer.NameOfRule == "unknown") { sw.Write("unknown" + ';'); }
            
            sw.Write(Convert.ToString(gamer.PrSSn1) + ';');
            sw.Write(Convert.ToString(gamer.PrSSn2) + ';'); // Правило количества поголовья на продажу (Сколько продавать)
            sw.Write(Convert.ToString(gamer.PrSSn3) + ';');

            sw.Write(Convert.ToString(gamer.PrSCn1) + ';');
            sw.Write(Convert.ToString(gamer.PrSCn2) + ';'); // Правило количества поголовья на покупку (Сколько плкупать)
            sw.Write(Convert.ToString(gamer.PrSCn3) + ';');

            sw.Write(Convert.ToString(gamer.Prcsale1) + ';');
            sw.Write(Convert.ToString(gamer.Prcsale2) + ';'); // Правило цены продажи поголовья (За сколько продавать)
            sw.Write(Convert.ToString(gamer.Prcsale3) + ';');

            sw.Write(Convert.ToString(gamer.Prccost1) + ';');
            sw.Write(Convert.ToString(gamer.Prccost2) + ';'); // Правило цены покупки поголовья  (За сколько покупать)
            sw.Write(Convert.ToString(gamer.Prccost3) + ';');

            sw.WriteLine("");
            sw.Close();
        
         }

        public static void GetProgress(ref Gamer gamer)
        {
            if (n1 == null)
            {
                n1 = new double[1];
                n2 = new double[1];
                n3 = new double[1];
                mony = new double[1];

                n1[0] = Convert.ToUInt64(gamer.n1);
                n2[0] = Convert.ToUInt64(gamer.n2);
                n3[0] = Convert.ToUInt64(gamer.n3);
                mony[0] = gamer.mony;
            }
            else
            {
                double[] N1 = new double[n1.Length + 1];
                double[] N2 = new double[n2.Length + 1];
                double[] N3 = new double[n3.Length + 1];
                double[] MONY = new double[mony.Length + 1];

                for (int i = 0; i < n1.Length; i++)
                {
                    N1[i] = Convert.ToUInt64(n1[i]);
                    N2[i] = Convert.ToUInt64(n2[i]);
                    N3[i] = Convert.ToUInt64(n3[i]);
                    MONY[i] = mony[i];
                }

                N1[N1.Length - 1] = Convert.ToUInt64(gamer.n1);
                N2[N2.Length - 1] = Convert.ToUInt64(gamer.n2);
                N3[N3.Length - 1] = Convert.ToUInt64(gamer.n3);
                MONY[MONY.Length - 1] = gamer.mony;

                n1 = N1;
                n2 = N2;
                n3 = N3;
                mony = MONY;
            }

        }

        // Обновляет значения, зависящие от времени
        public static void TimeRefresh(ref Gamer gamer)
        {
            gamer.n1 = Convert.ToUInt64(gamer.dn1 * gamer.n1);
            gamer.n2 = Convert.ToUInt64(gamer.dn2 * gamer.n2);
            gamer.n3 = Convert.ToUInt64(gamer.dn3 * gamer.n3);
            gamer.mony = gamer.mony - (gamer.n1 * gamer.s1 + gamer.n2 * gamer.s2 + gamer.n3 * gamer.s3);
            gamer.time = Convert.ToInt16(gamer.time - 1);
        }

        // Примененик КА r=1
        public static void NewSizeKA_null_boundory(double[] mass, out double[] k)
        {
            double[] size = new double[mass.Length + 2];

            for (int i = 1; i < size.Length - 1; i++)
            {
                size[i] = mass[i - 1];
            }

            k = new double[mass.Length];

            for (int i = 0; i < mass.Length; i++)
            {

                if (size[i] == 0 && size[i + 1] == 0 && size[i + 2] == 0)
                {
                    k[i] = rule[0];
                }

                if (size[i] == 0 && size[i + 1] == 0 && size[i + 2] == 1)
                {
                    k[i] = rule[1];
                }

                if (size[i] == 0 && size[i + 1] == 1 && size[i + 2] == 0)
                {
                    k[i] = rule[2];
                }

                if (size[i] == 0 && size[i + 1] == 1 && size[i + 2] == 1)
                {
                    k[i] = rule[3];
                }

                if (size[i] == 1 && size[i + 1] == 0 && size[i + 2] == 0)
                {
                    k[i] = rule[4];
                }

                if (size[i] == 1 && size[i + 1] == 0 && size[i + 2] == 1)
                {
                    k[i] = rule[5];
                }

                if (size[i] == 1 && size[i + 1] == 1 && size[i + 2] == 0)
                {
                    k[i] = rule[6];
                }

                if (size[i] == 1 && size[i + 1] == 1 && size[i + 2] == 1)
                {
                    k[i] = rule[7];
                }

            }
        }

        public static void NewSizeKA_connect_boundory(double[] mass, out double[] k)
        {
            double[] size = new double[mass.Length + 2];

            try
            {
                size[0] = mass[mass.Length - 1];
                size[size.Length - 1] = mass[0];
            }
            catch (Exception)
            {
 //               MessageBox.Show("input zero");
            }
            finally
            {
                size[0] = 0;
                size[size.Length - 1] = 0;
            }

            for (int i = 1; i < size.Length - 1; i++)
            {
                size[i] = mass[i - 1];
            }

            k = new double[mass.Length];

            for (int i = 0; i < mass.Length; i++)
            {
                if (size[i] == 0 && size[i + 1] == 0 && size[i + 2] == 0)
                {
                    k[i] = rule[0];
                }

                if (size[i] == 0 && size[i + 1] == 0 && size[i + 2] == 1)
                {
                    k[i] = rule[1];
                }

                if (size[i] == 0 && size[i + 1] == 1 && size[i + 2] == 0)
                {
                    k[i] = rule[2];
                }

                if (size[i] == 0 && size[i + 1] == 1 && size[i + 2] == 1)
                {
                    k[i] = rule[3];
                }

                if (size[i] == 1 && size[i + 1] == 0 && size[i + 2] == 0)
                {
                    k[i] = rule[4];
                }

                if (size[i] == 1 && size[i + 1] == 0 && size[i + 2] == 1)
                {
                    k[i] = rule[5];
                }

                if (size[i] == 1 && size[i + 1] == 1 && size[i + 2] == 0)
                {
                    k[i] = rule[6];
                }

                if (size[i] == 1 && size[i + 1] == 1 && size[i + 2] == 1)
                {
                    k[i] = rule[7];
                }

            }
        }

        public static void Prodaga(double se, int up, ref Gamer gamer)
        {
            switch (up)
            {
                case 1:
                    {
                        if (se < gamer.n1)
                        {
                            gamer.mony += se * gamer.csale1;
                            double dd = gamer.n1 - se;
                            gamer.n1 =  dd / 1;
                        }
                        else
                        {
                            gamer.mony += gamer.n1 * gamer.csale1;
                            gamer.n1 = 0;
                        }
                        break;
                    }

                case 2:
                    {
                        if (se < gamer.n2)
                        {
                            gamer.mony += se * gamer.csale2;
                            double dd = gamer.n2 - se;
                            gamer.n2 = dd / 1;
                        }
                        else
                        {
                            gamer.mony += gamer.n2 * gamer.csale2;
                            gamer.n2 = 0;
                        }
                        break;
                    }

                case 3:
                    {
                        if (se < gamer.n3)
                        {
                            gamer.mony += se * gamer.csale3;
                            double dd = gamer.n3 - se;
                            gamer.n3 = dd / 1;
                        }
                        else
                        {
                            gamer.mony += gamer.n3 * gamer.csale3;
                            gamer.n3 = 0;
                        }
                        break;
                    }
            }
        }

        public static void Pokypka(double co, int up, ref Gamer gamer)
        {
            switch (up)
            {
                case 1:
                    {
                        if (gamer.mony > 0)
                        {
                            if (gamer.mony >= (co * gamer.ccost1))
                            {
                                if (co * gamer.ccost1 < 0) { gamer.mony = gamer.mony + (co * gamer.ccost1); }
                                else { gamer.mony = gamer.mony - (co * gamer.ccost1); }
                                double g = gamer.n1 + co;
                                if (g < 0)
                                { gamer.n1 = (g * (-1)) / 1; }
                                else gamer.n1 = g / 1;
                            }
                            else
                            {
                                if (gamer.ccost1 == 0) co = 0;
                                else co = gamer.mony / gamer.ccost1;
                                if (co < 0) co *= -1;
                                if (gamer.mony > 0 && gamer.mony - co * gamer.ccost1 > 0)
                                {
                                    gamer.mony -= co * gamer.ccost1;
                                    gamer.n1 = (gamer.n1 + co) / 1;
                                }
                            }
                        }
                        break;
                    }

                case 2:
                    {
                        if (gamer.mony > 0)
                        {
                            if (gamer.mony >= (co * gamer.ccost2))
                            {
                                if (co * gamer.ccost2 < 0) { gamer.mony = gamer.mony + (co * gamer.ccost2); }
                                else { gamer.mony = gamer.mony - (co * gamer.ccost2); }
                                double g = gamer.n2 + co;
                                if (g < 0)
                                { gamer.n2 = (g * (-1)) / 1; }
                                else gamer.n2 = g / 1;
                            }
                            else
                            {
                                if (gamer.ccost2 == 0) co = 0;
                                else co = gamer.mony / gamer.ccost2;
                                if (co < 0) co *= -1;
                                if (gamer.mony > 0 && gamer.mony - co * gamer.ccost2 > 0)
                                {
                                    gamer.mony -= co * gamer.ccost2;
                                    gamer.n2 = (gamer.n2 + co) / 1;
                                }
                            }
                        }
                        break;
                    }

                case 3:
                    {
                        if (gamer.mony > 0)
                        {
                            if (gamer.mony >= (co * gamer.ccost3))
                            {
                                if (co * gamer.ccost3 < 0) { gamer.mony = gamer.mony + (co * gamer.ccost3); }
                                else { gamer.mony = gamer.mony - (co * gamer.ccost3); }
                                double g = gamer.n3 + co;
                                if (g < 0)
                                { gamer.n3 = (g * (-1)) / 1; }
                                else gamer.n3 = g / 1;
                            }
                            else
                            {
                                if (gamer.ccost3 == 0) co = 0;
                                else co = gamer.mony / gamer.ccost3;
                                if (co < 0) co *= -1;
                                if (gamer.mony > 0 && gamer.mony - co * gamer.ccost3 > 0)
                                {
                                    gamer.mony -= co * gamer.ccost3;
                                    gamer.n3 = (gamer.n3 + co) / 1;
                                }
                            }
                        }
                        break;
                    }
            }
        }

        // Вспомогательная ф-я для определения стратегии
        private static string ChooseStrategy(double[] mony, double[] n1, double[] n2, double[] n3)
        {
            string message = null;
            // Проверка на рост поголовья и нулевую прибыль
            {
                // n1 возросло и деньги не убыли
                if (n1[0] < n1[n1.Length - 1] && mony[mony.Length - 1] >= mony[0] * 0.9 && mony[mony.Length - 1] <= mony[0] * 1.1)
                {
                 //   MessageBox.Show("Это стратегия роста поголовья" +
                 //       "\n Молодняк");
                    message = "Рост 'молодняк'";
                    return message;
                }

                // n2 возросло и деньги не убыли
                if (n2[0] < n2[n2.Length - 1] && mony[mony.Length - 1] >= mony[0] * 0.9 && mony[mony.Length - 1] <= mony[0] * 1.1)
                {
                //    MessageBox.Show("Это стратегия роста поголовья" +
                 //       "\n Зрелые");
                    message = "Рост 'зрелые'";
                    return message;
                }

                // n3 возросло и деньги не убыли
                if (n3[0] < n3[n3.Length - 1] && mony[mony.Length - 1] >= mony[0] * 0.9 && mony[mony.Length - 1] <= mony[0] * 1.1)
                {
                 //   MessageBox.Show("Это стратегия роста поголовья" +
                  //      "\n Страрые");
                    message = "Рост 'старые'";
                    return message;
                }
            }

            // Проверка на рост поголовья и прибыли
            {
                bool needSizeN = false; // Ростет поголовье
                bool needSizeMony = false; // Ростет прибыль
                {
                    // рост n1
                    if (n1[0] < n1[n1.Length - 1])
                    {
                        needSizeN = true;
                    }

                    // рост n2
                    if (n2[0] < n2[n2.Length - 1])
                    {
                        needSizeN = true;
                    }

                    // рост n3
                    if (n3[0] < n3[n3.Length - 1])
                    {
                        needSizeN = true;
                    }

                    // рост mony
                    for (int i = 1; i < mony.Length; i++)
                    {
                        if (mony[0] < mony[i])
                        {
                            needSizeMony = true;
                        }
                    }

                    // вывод
                    {
                        if (needSizeN && needSizeMony)
                        {
                          //  MessageBox.Show("Рост поголовья и прибыли
                            message = "Рост поголовья и прибыли";
                            return message;
                        }
                    }
                }
            }

            // Проверка на разорение
            {
                // Все значения отрицательны
                {
                    int j = 0;
                    for (int i = 0; i < mony.Length; i++)
                    {
                        if (mony[i] < 0)
                            j++;
                        else break;
                    }

                    if (j == mony.Length)
                    {
                    //    MessageBox.Show("Это стратегия разорения" + "\n(Все значения отрицательны)");
                        message = "Разорение";
                        return message;
                    }
                }

                // Все значения невозрастают и есть хотябы одно отрицательное значение
                {
                    int j = 0;
                    bool k = false; // Наличие отрицательных чисел
                    for (int i = 1; i < mony.Length; i++)
                    {

                        if (mony[i - 1] > mony[i])
                            j++;
                        else break;
                        if (mony[i] < 0) k = true;
                    }

                    if (j == mony.Length || k == true)
                    {
                     //   MessageBox.Show("Это стратегия разорения" +
                     //       "\n(Все значения невозрастают и есть хотябы одно отрицательное значение)");
                        message = "Разорение";
                        return message;
                    }
                }

                // Последнее значение меньше первого
                {
                    if (mony[mony.Length - 1] < mony[0])
                    {
                     //   MessageBox.Show("Это стратегия разорения" + "\n(Последнее значение меньше первого)");
                        message = "Разорение";
                        return message;
                    }
                }
            }

            if (message == null) message = "unknown";
            return message;
        }

        // Вспомогательная ф-я для определения стратегии
        public static string ChooseStrategy()
        {
            return ChooseStrategy(mony, n1, n2, n3);
        }

        public static void GetStrategyByFile(OpenFileDialog openFileDialog1, int delta)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);

                bool first = true;
                int item = delta;
                double[] data = new double[item];
                double[] Data = new double[item];

                while (!sr.EndOfStream)
                {
                    if (first == true)
                    {
                        for (int j = 0; j < delta; j++)
                        {
                            data[j] = Convert.ToDouble(sr.ReadLine());
                        }

                        for (int i = 0; i < item; i++)
                        {
                            Data[i] = data[i];
                        }

                        item += delta;
                        first = false;
                    }
                    else
                    {
                        data = new double[item];
                        for (int i = 0; i < item - delta; i++)
                        {
                            data[i] = Data[i];
                        }

                        for (int i = 0; i < delta; i++)
                        {
                            data[item - delta + i] = Convert.ToDouble(sr.ReadLine());
                        }

                        Data = new double[item];
                        for (int i = 0; i < item; i++)
                        {
                            Data[i] = data[i];
                        }

                        item += delta;
                    }
                }
                sr.Close();



                double[] _mony = new double[data.Length / delta];
                double[] _n1 = new double[data.Length / delta];
                double[] _n2 = new double[data.Length / delta];
                double[] _n3 = new double[data.Length / delta];

                int k = 0, l = 0;
                while (k < data.Length)
                {
                    _n1[l] = data[k]; k++;
                    _n2[l] = data[k]; k++;
                    _n3[l] = data[k]; k++;
                    _mony[l] = data[k]; k++;
                    l++;
                }

                ChooseStrategy(_mony, _n1, _n2, _n3);
            }
        }
    }
}




