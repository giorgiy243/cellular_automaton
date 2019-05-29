using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public static class Compite
{
    public Compite()
    {
    }

    // Перевод в двоичную СО
    public static void TranslateTwo(int chislo, out int[] d, string sss = "", bool Aktualnost = false)
    {
        int p = chislo;
        int i = 0;

        // Количество значемых цыфр в двоичной форме записи
        while (p > 0)
        {
            p = p / 2;
            i++;
        }

        d = new int[i];
        _arr = new int[i];
        p = chislo;

        for (int g = i; g > 0; g--)
        {
            d[g - 1] = p % 2;
            _arr[g - 1] = d[g - 1];
            p = p / 2;
        }

        //// Вывод в фаил
        //if (Aktualnost == false)
        //{
        //    PrintFileTwo(sss);
        //}

        for (int j = 0; j < _arr.Length; j++)
        {
            _arr[j] = 0;
        }

    }

    // Перевод в десятичную СО
    public static void TranslateTen(int[] ir, string sss, out int otv, bool Aktualnost = false)
    {
        otv = 0;
        for (int i = 0; i < ir.Length; i++)
        {
            int d = 1;
            for (int f = 0; f < ir.Length - 1 - i; f++)
            {
                d *= 2;
            }
            otv += ir[i] * d;
        }

        //if (Aktualnost == false) { PrintFileTen(otv, sss); }

    }

    // Печать в ф-л Итог
    private static void Print(int chislo, string str)
    {
        StreamWriter sw = File.AppendText(Path.Combine(Application.StartupPath, /*str+*/"Итог.csv"));

        sw.Write(Convert.ToString(chislo) + "" + str);
    
        sw.WriteLine("");
        sw.Close();
    }

    // Записывает прогресс в ф-л
    public static void GetProgress(Form3 f3, int n1, int n2, int n3, int mony,
                                int csale1, int csale2, int csale3, int ccost1, int ccost2, int ccost3,
                                int s1, int s2, int s3, int time, int ENDtime, int rule, bool _chbAktualnist)
    {
        Print(n1 - _N1, "Baby");
        Print(n2 - _N2, "Teen");
        Print(n3 - _N3, "Old");
        Print(mony - _MONY, "mony");
    }

    // Обновляет значения, зависящие от времени
    public static void TimeRefresh (int s1, int s2, int s3, int n1, int n2, int n3, int time,    
                                    int mony, out int fn1, out int fn2, out int fn3, out int ftime, 
                                    out int fmony)
    {
        fn1 = Convert.ToInt32(_dn1 * n1);
        fn2 = Convert.ToInt32(_dn2 * n2);
        if (Convert.ToInt32(_dn3 * n3) > 0)
            fn3 = Convert.ToInt32(_dn3 * n3);
        else fn3 = 0;
        fmony = mony - (n1 * s1 + n2 * s2 + n3 * s3);

        ftime ++;
    }


    public void NewSizeKA (int[] mass, int[] tule, string sss, out int[] k, bool Aktualnost = false)
    {
        int[] size = new int[mass.Length + 2];

        for (int i = 1; i < size.Length - 1; i++)
        {
            size[i] = mass[i - 1];
        }

        k = new int[mass.Length];

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
        //if (Aktualnost == false) { PrintFileMass(k, sss); }
    }

    public static void Prodaga(int se, int cse, int k, out int n)
    {

        if (se < k)
        {
            _mony += se * cse;
            int dd = k - se;
            n = dd;
        }
        else
        {
            _mony += k * cse;
            n = 0;
        }
    }

    public static void Pokypka(int co, int cco, int k, out int n)
    {

        if (_mony >= (co * cco))
        {
            if (co * cco < 0) { _mony = _mony + (co * cco); }
            else { _mony = _mony - (co * cco); }
            int g = k + co;
            if (g < 0)
            { n = g * (-1); }
            else n = g;
        }
        else
        {
            if (cco == 0) co = 0;
            else co = _mony / cco;
            if (co < 0) co *= -1;
            if (_mony > 0 && _mony - co * cco > 0)
            {
                _mony -= co * cco;
                n = k + co;
            }
            else n = k;
        }
    }




}
