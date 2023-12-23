using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;

namespace Visualka6
{
    public partial class LineChart : UserControl
    {
        private List<PointF> points; // список
        private Color lineColor;
        private string xName;
        private string yName;
        private string clor;
        private float x;
        private float y;
        int countDots = 0;

        public LineChart()
        {
            InitializeComponent();

            points = new List<PointF>(); // инициализация списка
            lineColor = Color.Blue;
            xName = "X";
            yName = "Y";
            chart1.ChartAreas["ChartArea1"].AxisX.Title = xName;
            chart1.ChartAreas["ChartArea1"].AxisY.Title = yName;
            chart1.Series["Series1"].Color = lineColor;
        }

        public void AddPoints(float a, float b)
        {
            PointF point = new PointF(x, y); // создание точки
            points.Add(point); // добавление точки в список
            UpdateChart();
        }

        public void SetLineColor(string color)
        {
            lineColor = Color.FromName(color);
            chart1.Series["Series1"].Color = lineColor;
        }

        private void UpdateChart()
        {
            //chart1.Series["Series1"].Points.Clear();
            chart1.Series["Series1"].Points.AddXY(x, y); // добавление точек в график
        }

        private void button1_Click(object sender, EventArgs e) // визуал
        {
            clor = textBox1.Text;
            xName = textBox2.Text;
            yName = textBox3.Text;
            SetLineColor(clor);
            chart1.ChartAreas["ChartArea1"].AxisX.Title = xName;
            chart1.ChartAreas["ChartArea1"].AxisY.Title = yName;
        }

        private void button2_Click(object sender, EventArgs e) // добавление точек
        {
            x = Convert.ToSingle(textBox4.Text);
            y = Convert.ToSingle(textBox5.Text);
            AddPoints(x, y);
            countDots = countDots + 1;
            textBox6.Text = Convert.ToString(countDots);

            // Очистка графика перед добавлением новых точек
            chart1.Series["Series1"].Points.Clear();

            // Добавление всех точек из списка в график
            foreach (PointF point in points)
            {
                chart1.Series["Series1"].Points.AddXY(point.X, point.Y);
            }
        }

        private void button3_Click(object sender, EventArgs e) // очистка
        {
            points.Clear();
            chart1.Series["Series1"].Points.Clear();
            countDots = 0;
            textBox6.Clear();
        }

        private void button4_Click(object sender, EventArgs e) // сохранение
        {
            //chart1.SaveImage("D:\\Лабараторные работы\\Lab6_charts\\test.jpg", ChartImageFormat.Jpeg);
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JPEG Image|*.jpg";
            saveFileDialog.Title = "Save Chart Image";
            saveFileDialog.FileName = "test.jpg";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                chart1.SaveImage(saveFileDialog.FileName, ChartImageFormat.Jpeg);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (points.Count > 1)
            {
                // Удаление последней точки из списка
                points.RemoveAt(points.Count - 1);

                // Очистка графика
                chart1.Series["Series1"].Points.Clear();

                // Добавление всех точек из списка в график
                for (int i = 0; i < points.Count - 1; i++)
                {
                    chart1.Series["Series1"].Points.AddXY(points[i].X, points[i].Y);
                }

                countDots = points.Count; // Обновление счетчика точек
                UpdateChart(); // Обновление графика
                textBox6.Text = countDots.ToString(); // Обновление счетчика в пользовательском интерфейсе
            }
            else if (points.Count == 1)
            {
                // Удаление последней точки из списка
                points.RemoveAt(points.Count - 1);

                // Очистка графика
                chart1.Series["Series1"].Points.Clear();

                countDots = points.Count; // Обновление счетчика точек
                textBox6.Text = countDots.ToString(); // Обновление счетчика в пользовательском интерфейсе
            }
        }
    }
}
