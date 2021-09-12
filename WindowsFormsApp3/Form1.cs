using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double v = 0;
            double s = 0;
            double t = 0; // время остановки 

            if (textBox1.Text.Contains("-"))

            {
                MessageBox.Show("Переменная S содержит неправильный формат данных");
            }
            {
                s = Convert.ToDouble(textBox1.Text);
            }
            

        
            if (textBox2.Text.Contains("-"))
            {
                MessageBox.Show("Переменная V содержит неправильный формат данных");
            }
            else
            {
                v = Convert.ToDouble(textBox2.Text);
            }


            if (textBox3.Text.Contains("-"))
            {
                MessageBox.Show("Переменная T содержит неправильный формат данных");
            }
            else
            {
                t = Convert.ToDouble (textBox3.Text);
            }

           if ((textBox1.Text.Contains("-")))
                {
                textBox4.Text = ("Неправильный формат данных").ToString();
                }

           else if ((textBox2.Text.Contains("-")))
            {
                textBox4.Text = ("Неправильный формат данных").ToString();
            }

            else if ((textBox3.Text.Contains("-")))
            {
                textBox4.Text = ("Неправильный формат данных").ToString();
            }

           else
            {
                textBox4.Text = (s/((s / v) + t)).ToString();
                textBox4.ReadOnly = true;
            }

           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
            else if (textBox1.Text.Length == 0)
                if (e.KeyChar == '0') e.Handled = true;
        }

        private void textBox3_KeyPress_2(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
           else if (textBox1.Text.Length == 0)
                if (e.KeyChar == '0') e.Handled = true;
        }

        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
            else if (textBox1.Text.Length == 0)
                if (e.KeyChar == '0') e.Handled = true;
        }
    }
}
