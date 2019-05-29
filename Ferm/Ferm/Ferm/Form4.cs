using System.Windows.Forms;
using System.IO;
using System;

namespace Ferm
{
    public partial class Form4 : Form
    {
        private Int16 size = 2; // Количество графиков
        private Int16 _size = 0; // Указатель на конец загрузки ф-ов
        private Int16 time = 2; // Время расчёта
        private bool first = true;
        private Int16 rec = 0; // Указатель на свободный элемент в массиве
        private double[] arr; // Масив значений
        int label = 0;

        public Form4()
        {
            InitializeComponent();

            // chart1.ChartAreas[0].AxisX.ScaleView.Zoom(0, _n); //зумирование
            chart1.ChartAreas[0].CursorX.IsUserEnabled = true; // возможность масштабирования
            chart1.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;  // включения возможности выбора интервала для масштабирования
            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;  // масштабирование по оси X
            chart1.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;   // полоса прокрутки

            //  chart1.ChartAreas[0].AxisY.ScaleView.Zoom(0, 0.0005); //зумирование
            chart1.ChartAreas[0].CursorY.IsUserEnabled = true; // возможность масштабирования
            chart1.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;  // включения возможности выбора интервала для масштабирования
            chart1.ChartAreas[0].AxisY.ScaleView.Zoomable = true;  // масштабирование по оси X
            chart1.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = true;   // полоса прокрутки
        }

        private void ReadOprions()
        {
            size = Convert.ToInt16(numericUpDown1.Value);
            time = Convert.ToInt16(numericUpDown2.Value);
        }

        // Прорисовка графика
        private void ShowGraphics()
        {
            double[] print = new double[time];
            print.Initialize();

            for (int j = 0; j < time; j++)    // нахождение среднего значения точки
            {
                for (int i = j; i < time * size; i += time)
                {
                    print[j] += arr[i];
                }
            }

            for (int i = 0; i < time; i++) //Вывод графика
            {
                chart1.Series[0].Points.AddXY(i + 1, print[i] / size);
            }
        }

        // Обновление индикатора формы
        private void UpdateLable(bool end = false)
        {
            label++;
            if (end == true) label = 0;
            label4.Text = Convert.ToString(label);
        }

        // Загрузка данных
        private void button1_Click(object sender, EventArgs e)
        {
            if (first == true) // Инициализация
            {
                ReadOprions();
                arr = new double[size * time];
                arr.Initialize();
                UpdateLable(true);
                chart1.Series[0].Points.Clear();
            }

            first = false;

            if (openFileDialog1.ShowDialog() == DialogResult.OK) // считываем значения
            {
                StreamReader str = new StreamReader(openFileDialog1.FileName);
                for (int i = 0; i < time; i++)
                {
                    arr[i + rec] = Convert.ToDouble(str.ReadLine());
                }
                str.Close();
            }
            rec += time; // сдвигаем указатель на свободную ячейку в массиве
            _size++;
            UpdateLable();

            if (size == _size)
            {
                ShowGraphics();
                rec = 0;
                _size = 0;
                first = true;
            }
        }
    }
}
