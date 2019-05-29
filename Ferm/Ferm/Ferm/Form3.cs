using System.Windows.Forms;
using System.IO;
using System;

namespace Ferm
{
    public partial class Form3 : Form
    {
        private Int16 x = 1;
        public Form3()
        {
            InitializeComponent();

            // chart1.ChartAreas[0].AxisX.ScaleView.Zoom(0, _time + 1); //зумирование
            chart1.ChartAreas[0].CursorX.IsUserEnabled = true; // возможность масштабирования
            chart1.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;  // включения возможности выбора интервала для масштабирования
            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;  // масштабирование по оси X
            chart1.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;   // полоса прокрутки

            // chart1.ChartAreas[0].AxisY.ScaleView.Zoom(0, _time + 1); //зумирование
            chart1.ChartAreas[0].CursorY.IsUserEnabled = true; // возможность масштабирования
            chart1.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;  // включения возможности выбора интервала для масштабирования
            chart1.ChartAreas[0].AxisY.ScaleView.Zoomable = true;  // масштабирование по оси X
            chart1.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = true;   // полоса прокрутки
        }

        // Вывод значений в фл "Актуальность.csv"
        private void PrintToFile(double s, Int16 rule)
        {
            StreamWriter SW = File.AppendText(Path.Combine(Application.StartupPath, "Актуальность" + Convert.ToString(rule) + ".csv"));
            SW.WriteLine(s);
            SW.Close();
        }

        // Построение графика Актуальности
        public void CreateGrafhikAktualnost(ref Gamer gamer)
        {
            double f1 = gamer.n1 + gamer.n2 + gamer.n3; // Количество поголовья
            double f2 = (gamer.csale1 - gamer.s1) + (gamer.csale2 - gamer.s2) + (gamer.csale3 - gamer.s3);  // Обусловленность выгоды при продаже
            double f3 = gamer.ccost1 + gamer.ccost2 + gamer.ccost3;  // Цна продажи
            double f4 = gamer.mony;  // свободный капитал
            double f5 = (-1) * (gamer.n1 * gamer.s1 + gamer.n2 * gamer.s2 + gamer.n3 * gamer.s3); // Затраты на содержание на следующем контроле

            double y = Math.Atan(f1 + f3 + f2 + f4 + f5) * 1000 / Math.PI + 500;
            //if (_chbAktualnist == true) PrintToFile(y); // запись в фаил значения актуальности

            chart1.Series[0].Points.AddXY(x, y);
            x++;

            PrintToFile(y, gamer.rule);

            if (gamer.time == 0)
            {
                x = 1;
                chart1.SaveImage("Актуальность " + gamer.rule, System.Drawing.Imaging.ImageFormat.Gif);
            }
        }
    }
}
