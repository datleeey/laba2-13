using System;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Rectangle
        {
            // Поля для ширини і висоти
            private double width;
            private double height;

            // Конструктор без параметрів
            public Rectangle()
            {
                width = 1;
                height = 1;
            }

            // Конструктор з параметрами
            public Rectangle(double width, double height)
            {
                this.width = width;
                this.height = height;
            }

            // Властивості для ширини та висоти
            public double Width
            {
                get { return width; }
                set { width = value; }
            }

            public double Height
            {
                get { return height; }
                set { height = value; }
            }

            // Метод для обчислення периметра
            public double CalculatePerimeter()
            {
                return 2 * (width + height);
            }

            // Метод для обчислення площі
            public double CalculateArea()
            {
                return width * height;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Попытка преобразовать текстовые поля в числа
                double width = Convert.ToDouble(txtWidth.Text);
                double height = Convert.ToDouble(txtHeight.Text);

                // Создаём объект класса Rectangle с введёнными значениями
                Rectangle rect = new Rectangle(width, height);

                // Вычисляем периметр и площадь
                double perimeter = rect.CalculatePerimeter();
                double area = rect.CalculateArea();

                // Выводим результаты на форму
                labelP.Text = "Периметр: " + perimeter.ToString();
                labelS.Text = "Площа: " + area.ToString();
            }
            catch (Exception ex)
            {
                // Если произошла ошибка, создаём прямоугольник с параметрами по умолчанию
                MessageBox.Show("Некоректні дані. Використовується стандартний прямокутник (ширина = 1, висота = 1).");

                // Создаём объект с использованием конструктора без параметров
                Rectangle rect = new Rectangle();

                // Вычисляем периметр и площадь для прямоугольника с параметрами по умолчанию
                double perimeter = rect.CalculatePerimeter();
                double area = rect.CalculateArea();

                // Выводим результаты на форму
                labelP.Text = "Периметр: " + perimeter.ToString();
                labelS.Text = "Площа: " + area.ToString();
            }
        }

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelP_Click(object sender, EventArgs e)
        {

        }

        private void labelS_Click(object sender, EventArgs e)
        {

        }
    }
}
