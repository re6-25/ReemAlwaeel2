using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = numbers.Text;
            int number;
            if (IsValidNumber(input, out number))
            {
                label1.Text = (number + 10).ToString();
            }
            else
            {
                MessageBox.Show("يرجى إدخال عدد صحيح");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string input = numbers.Text;
            int number;
            if (IsValidNumber(input, out number))
            {
                int factorial = 1;
                for (int i = 1; i <= number; i++)
                {
                    factorial *= i;
                }
                label2.Text = factorial.ToString();
            }
            else
            {
                MessageBox.Show("يرجى إدخال عدد صحيح");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string input = numbers.Text;
            int number;
            if (IsValidNumber(input, out number))
            {
                label3.Text = (number - 5).ToString();
            }
            else
            {
                MessageBox.Show("يرجى إدخال عدد صحيح");
            }
        }
        private bool IsValidNumber(string input, out int number)
        {
            number = 0;
            if (string.IsNullOrEmpty(input))
                return false;

            for (int i = 0; i < input.Length; i++)
            {
                if (!char.IsDigit(input[i]))
                    return false;
            }

            number = int.Parse(input);
            return true;
        }

        private void numbers_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
