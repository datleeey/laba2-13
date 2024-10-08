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

        // Клас прямокутника
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

            // Властивості для ширини
            public double Width
            {
                get { return width; }
                set { width = value; }
            }

            // Властивості для висоти
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

        // Обробник події для кнопки "Обчислити"
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Спроба перетворити введені дані в числа
                double width = Convert.ToDouble(txtWidth.Text);
                double height = Convert.ToDouble(txtHeight.Text);

                // Створення об'єкта класу Rectangle з введеними параметрами
                Rectangle rect = new Rectangle(width, height);

                // Обчислення периметра і площі
                double perimeter = rect.CalculatePerimeter();
                double area = rect.CalculateArea();

                // Виведення результатів на форму
                labelP.Text = "Периметр: " + perimeter.ToString();
                labelS.Text = "Площа: " + area.ToString();
            }
            catch (Exception ex)
            {
                // Якщо виникла помилка, використовується прямокутник з параметрами за замовчуванням
                MessageBox.Show("Некоректні дані. Використовується стандартний прямокутник (ширина = 1, висота = 1).");

                // Створення об'єкта з використанням конструктора без параметрів
                Rectangle rect = new Rectangle();

                // Обчислення периметра і площі для прямокутника за замовчуванням
                double perimeter = rect.CalculatePerimeter();
                double area = rect.CalculateArea();

                // Виведення результатів на форму
                labelP.Text = "Периметр: " + perimeter.ToString();
                labelS.Text = "Площа: " + area.ToString();
            }
        }

        // Обробник зміни тексту в полі для ширини
        private void txtWidth_TextChanged(object sender, EventArgs e)
        {

        }

        // Обробник зміни тексту в полі для висоти
        private void txtHeight_TextChanged(object sender, EventArgs e)
        {

        }

        // Обробник натискання на мітку для периметра
        private void labelP_Click(object sender, EventArgs e)
        {

        }

        // Обробник натискання на мітку для площі
        private void labelS_Click(object sender, EventArgs e)
        {

        }
    }
}
