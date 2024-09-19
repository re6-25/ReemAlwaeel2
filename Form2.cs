using System;
using System.Drawing;
using System.Windows.Forms;

namespace project2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            device1.Click += traingforsender;
            device2.Click += traingforsender;
            purple.Click += traingforsender;
            BLACK.Click += traingforsender;
            Blue.Click += traingforsender;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void traingforsender(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                if (sender == purple)
                {
                    button4.BackColor = Color.Purple;
                }
                else if (sender == BLACK)
                {
                    button4.BackColor = Color.Black;
                }
                else if (sender == Blue)
                {
                    button4.BackColor = Color.DarkBlue;
                }
            }
            else if (sender is Label)
            {
                if (sender == device1)
                {
                    button4.Text = device1.Text;
                }
                else if (sender == device2)
                {
                    button4.Text = device2.Text;
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
