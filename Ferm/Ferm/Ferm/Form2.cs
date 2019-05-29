using System;
using System.IO;
using System.Windows.Forms;

namespace Ferm
{
    public partial class Form2 : Form
    {
        public Form2()
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

        // Прорисовка по чекбоксам
        private void InstrtGraphicks()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader str = new StreamReader(openFileDialog1.FileName);
                int x = 1;
                double y = 0;
                while (!str.EndOfStream)
                {
                    if (checkBox1.Checked == true)
                    {
                        if (checkBox2.Checked == true)
                        {
                            if (checkBox3.Checked == true)
                            {
                                if (checkBox4.Checked == true)  // 1 2 3 4
                                {
                                    y = Convert.ToDouble(str.ReadLine());
                                    chart1.Series[0].Points.AddXY(x, y);

                                    y = Convert.ToDouble(str.ReadLine());
                                    chart1.Series[1].Points.AddXY(x, y);

                                    y = Convert.ToDouble(str.ReadLine());
                                    chart1.Series[2].Points.AddXY(x, y);

                                    y = Convert.ToDouble(str.ReadLine());
                                    chart1.Series[3].Points.AddXY(x, y);
                                }
                                else    // 1 2 3
                                {
                                    y = Convert.ToDouble(str.ReadLine());
                                    chart1.Series[0].Points.AddXY(x, y);

                                    y = Convert.ToDouble(str.ReadLine());
                                    chart1.Series[1].Points.AddXY(x, y);

                                    y = Convert.ToDouble(str.ReadLine());
                                    chart1.Series[2].Points.AddXY(x, y);

                                    str.ReadLine();
                                }
                            }
                            else
                            {
                                if (checkBox4.Checked == true)  // 1 2 4
                                {
                                    y = Convert.ToDouble(str.ReadLine());
                                    chart1.Series[0].Points.AddXY(x, y);

                                    y = Convert.ToDouble(str.ReadLine());
                                    chart1.Series[1].Points.AddXY(x, y);

                                    str.ReadLine();

                                    y = Convert.ToDouble(str.ReadLine());
                                    chart1.Series[3].Points.AddXY(x, y);
                                }
                                else    // 1 2
                                {
                                    y = Convert.ToDouble(str.ReadLine());
                                    chart1.Series[0].Points.AddXY(x, y);

                                    y = Convert.ToDouble(str.ReadLine());
                                    chart1.Series[1].Points.AddXY(x, y);

                                    str.ReadLine();

                                    str.ReadLine();

                                }
                            }

                        }
                        else
                        {
                            if (checkBox3.Checked == true)
                            {
                                if (checkBox4.Checked == true)   // 1 3 4 
                                {
                                    y = Convert.ToDouble(str.ReadLine());
                                    chart1.Series[0].Points.AddXY(x, y);

                                    str.ReadLine();

                                    y = Convert.ToDouble(str.ReadLine());
                                    chart1.Series[2].Points.AddXY(x, y);

                                    y = Convert.ToDouble(str.ReadLine());
                                    chart1.Series[3].Points.AddXY(x, y);
                                }
                                else   // 1 3
                                {
                                    y = Convert.ToDouble(str.ReadLine());
                                    chart1.Series[0].Points.AddXY(x, y);

                                    str.ReadLine();

                                    y = Convert.ToDouble(str.ReadLine());
                                    chart1.Series[2].Points.AddXY(x, y);

                                    str.ReadLine();
                                }
                            }
                            else
                            {
                                if (checkBox4.Checked == true)  // 1 4
                                {
                                    y = Convert.ToDouble(str.ReadLine());
                                    chart1.Series[0].Points.AddXY(x, y);

                                    str.ReadLine();

                                    str.ReadLine();

                                    y = Convert.ToDouble(str.ReadLine());
                                    chart1.Series[3].Points.AddXY(x, y);
                                }
                                else    // 1
                                {
                                    y = Convert.ToDouble(str.ReadLine());
                                    chart1.Series[0].Points.AddXY(x, y);

                                    str.ReadLine();

                                    str.ReadLine();

                                    str.ReadLine();
                                }
                            }
                        }
                    }
                    else
                    {
                        if (checkBox2.Checked == true)
                        {
                            if (checkBox3.Checked == true)
                            {
                                if (checkBox4.Checked == true)   // 2 3 4
                                {
                                    str.ReadLine();

                                    y = Convert.ToDouble(str.ReadLine());
                                    chart1.Series[1].Points.AddXY(x, y);

                                    y = Convert.ToDouble(str.ReadLine());
                                    chart1.Series[2].Points.AddXY(x, y);

                                    y = Convert.ToDouble(str.ReadLine());
                                    chart1.Series[3].Points.AddXY(x, y);
                                }
                                else    // 2 3
                                {
                                    str.ReadLine();

                                    y = Convert.ToDouble(str.ReadLine());
                                    chart1.Series[1].Points.AddXY(x, y);

                                    y = Convert.ToDouble(str.ReadLine());
                                    chart1.Series[2].Points.AddXY(x, y);

                                    str.ReadLine();
                                }
                            }
                            else
                            {
                                if (checkBox4.Checked == true)   // 2 4
                                {
                                    str.ReadLine();

                                    y = Convert.ToDouble(str.ReadLine());
                                    chart1.Series[1].Points.AddXY(x, y);

                                    str.ReadLine();

                                    y = Convert.ToDouble(str.ReadLine());
                                    chart1.Series[3].Points.AddXY(x, y);
                                }
                                else   // 2
                                {
                                    str.ReadLine();

                                    y = Convert.ToDouble(str.ReadLine());
                                    chart1.Series[1].Points.AddXY(x, y);

                                    str.ReadLine();

                                    str.ReadLine();
                                }
                            }
                        }
                        else
                        {
                            if (checkBox3.Checked == true)
                            {
                                if (checkBox4.Checked == true)   // 3 4
                                {
                                    str.ReadLine();

                                    str.ReadLine();

                                    y = Convert.ToDouble(str.ReadLine());
                                    chart1.Series[2].Points.AddXY(x, y);

                                    y = Convert.ToDouble(str.ReadLine());
                                    chart1.Series[3].Points.AddXY(x, y);
                                }
                                else   // 3
                                {
                                    str.ReadLine();

                                    str.ReadLine();

                                    y = Convert.ToDouble(str.ReadLine());
                                    chart1.Series[2].Points.AddXY(x, y);

                                    str.ReadLine();
                                }
                            }
                            else
                            {
                                if (checkBox4.Checked == true)   // 4
                                {
                                    str.ReadLine();

                                    str.ReadLine();

                                    str.ReadLine();

                                    y = Convert.ToDouble(str.ReadLine());
                                    chart1.Series[3].Points.AddXY(x, y);
                                }
                            }
                        }
                    }

                    x++;
                }

                str.Close();
            }
        }

        // Загрузить данные
        private void button1Load_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true || checkBox2.Checked == true ||
               checkBox3.Checked == true || checkBox4.Checked == true)
            {
                InstrtGraphicks();
            }
        }

        // Очищаем график
        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
            chart1.Series[3].Points.Clear();
        }
    }
}
