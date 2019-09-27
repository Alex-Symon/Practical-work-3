using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchProjectWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int DayOfWeek = Convert.ToInt32(textBoxA.Text);
            if (DayOfWeek <= 7)
            {
                switch (DayOfWeek)
                {
                    case 1:
                        labelRes.Text = ("Понедельник");
                        break;
                    case 2:
                        labelRes.Text = ("Вторник");
                        break;
                    case 3:
                        labelRes.Text = ("Среда");
                        break;
                    case 4:
                        labelRes.Text = ("Четверг");
                        break;
                    case 5:
                        labelRes.Text = ("Пятница");
                        break;
                    case 6:
                        labelRes.Text = ("Суббота");
                        break;
                    case 7:
                        labelRes.Text = ("Воскресенье");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Ошибка введения данных");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int MonthOfYear = Convert.ToInt32(textBoxA.Text);
            if (MonthOfYear <= 12)
            {
                switch (MonthOfYear)
                {
                    case 1:
                        labelRes.Text = ("Январь");
                        break;
                    case 2:
                        labelRes.Text = ("Февраль");
                        break;
                    case 3:
                        labelRes.Text = ("Март");
                        break;
                    case 4:
                        labelRes.Text = ("Апрель");
                        break;
                    case 5:
                        labelRes.Text = ("Май");
                        break;
                    case 6:
                        labelRes.Text = ("Июнь");
                        break;
                    case 7:
                        labelRes.Text = ("Июль");
                        break;
                    case 8:
                        labelRes.Text = ("Август");
                        break;
                    case 9:
                        labelRes.Text = ("Сентябрь");
                        break;
                    case 10:
                        labelRes.Text = ("Октябрь");
                        break;
                    case 11:
                        labelRes.Text = ("Ноябрь");
                        break;
                    case 12:
                        labelRes.Text = ("Декабрь");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Ошибка введения данных");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double x = Convert.ToInt32(textBoxA.Text);
            double y = Convert.ToInt32(textBoxB.Text);

            switch (textBoxOperation.Text)
            {
                case "+":
                    double sum;
                    sum = x + y;
                    labelRes.Text = Convert.ToString(sum);
                    break;
                case "-":
                    double sub;
                    sub = x - y;
                    labelRes.Text = Convert.ToString(sub);
                    break;
                case "*":
                    double mult;
                    mult = x * y;
                    labelRes.Text = Convert.ToString(mult);
                    break;
                case "/":
                    double div;
                    div = x / y;
                    labelRes.Text = Convert.ToString(div);
                    break;
                default: MessageBox.Show("Ошибка введения");
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
