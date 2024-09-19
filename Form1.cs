namespace project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2, num3;
            string opr1 = textBox2.Text;
            string opr2 = textBox4.Text;

            if (double.TryParse(textBox1.Text, out num1) &&
                double.TryParse(textBox3.Text, out num2) &&
                double.TryParse(textBox5.Text, out num3))
            {
                double result = CalculateWithPriority(num1, opr1, num2, opr2, num3);

                //  Õﬁﬁ „‰ «·‰ ÌÃ…
                if (double.IsNaN(result))
                {
                    MessageBox.Show("Â‰«ﬂ Œÿ√ ›Ì «·⁄„·Ì« ");
                    textBox2.Focus();
                }
                else
                {
                    textBox6.Text = result.ToString();
                }
            }
            else
            {
                if (!double.TryParse(textBox1.Text, out num1))
                {
                    MessageBox.Show("Ì—ÃÏ ≈œŒ«· «·—ﬁ„ «·√Ê· ’ÕÌÕ");
                    textBox1.Focus();
                }
                else if (!double.TryParse(textBox3.Text, out num2))
                {
                    MessageBox.Show("Ì—ÃÏ ≈œŒ«· «·—ﬁ„ «·À«‰Ì ’ÕÌÕ");
                    textBox3.Focus();
                }
                else if (!double.TryParse(textBox5.Text, out num3))
                {
                    MessageBox.Show("Ì—ÃÏ ≈œŒ«· «·—ﬁ„ «·À«·À ’ÕÌÕ");
                    textBox5.Focus();
                }
            }
        }

        private double proformoper(double num1, double num2, string opr)
        {
            switch (opr)
            {
                case "+":
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                case "*":
                    return num1 * num2;
                case "/":
                    return (num2 != 0) ? num1 / num2 : double.NaN; //  Õﬁﬁ „‰ «·ﬁ”„… ⁄·Ï ’›—
                default:
                    return double.NaN;
            }
        }

        private double CalculateWithPriority(double num1, string opr1, double num2, string opr2, double num3)
        {
            double firstResult = 0;

            // ≈–« ﬂ«‰  «·⁄„·Ì… «·√Ê·Ï ÷—» √Ê ﬁ”„…° ‰›–Â« √Ê·«
            if (opr1 == "*" || opr1 == "/")
            {
                firstResult = proformoper(num1, num2, opr1);
                return proformoper(firstResult, num3, opr2);
            }
            else // ≈–« ﬂ«‰  «·⁄„·Ì… «·√Ê·Ï Ã„⁄ √Ê ÿ—Õ
            {
                double secondResult = proformoper(num2, num3, opr2);
                return proformoper(num1, secondResult, opr1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.Text = "my second program"; //  ⁄ÌÌ‰ ⁄‰Ê«‰ «·›Ê—„
        }
    }
}
