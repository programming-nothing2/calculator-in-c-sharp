namespace Calculator
{
    public partial class Form1 : Form
    {
        float num1, num2;
        char op;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn00_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "00";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            op = '/';
            textBox1.Text = "";
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            op = '*';
            textBox1.Text = "";
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            op = '-';
            textBox1.Text = "";
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            op = '+';
            textBox1.Text = "";
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            num2 = float.Parse(textBox1.Text);
            float result = 0;

            if (op == '/')
            {
                result = num1 / num2;
            }
            if (op == '*')
            {
                result = num1 * num2;
            }
            if (op == '-') 
            { 
                result = num1 - num2;
            }
            if(op == '+')
            {
                result = num1 + num2;   
            }

            textBox1.Text = result.ToString();
        }
    }
}
