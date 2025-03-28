namespace HesapMakinası
{
    public partial class Form1 : Form
    {
        bool isClearOn = false;
        bool isOperated = false;
        double number1 = 0;
        int process = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void checkFirst(object sender, EventArgs e)
        {
            if (isClearOn)
            {
                label1.Text = "0";
                isClearOn = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
        }

        private void buttonNumber1_Click_1(object sender, EventArgs e)
        {
            checkFirst(sender, new EventArgs());
            label1.Text += "1";
        }

        private void buttonNumber2_Click(object sender, EventArgs e)
        {
            checkFirst(sender, new EventArgs());
            label1.Text += "2";
        }

        private void buttonNumber3_Click(object sender, EventArgs e)
        {
            checkFirst(sender, new EventArgs());
            label1.Text += "3";
        }

        private void buttonNumber4_Click(object sender, EventArgs e)
        {
            checkFirst(sender, new EventArgs());
            label1.Text += "4";
        }

        private void buttonNumber5_Click(object sender, EventArgs e)
        {
            checkFirst(sender, new EventArgs());
            label1.Text += "5";
        }

        private void buttonNumber6_Click(object sender, EventArgs e)
        {
            checkFirst(sender, new EventArgs());
            label1.Text += "6";
        }

        private void buttonNumber7_Click(object sender, EventArgs e)
        {
            checkFirst(sender, new EventArgs());
            label1.Text += "7";
        }

        private void buttonNumber8_Click(object sender, EventArgs e)
        {
            checkFirst(sender, new EventArgs());
            label1.Text += "8";
        }

        private void buttonNumber9_Click(object sender, EventArgs e)
        {
            checkFirst(sender, new EventArgs());
            label1.Text += "9";
        }
        private void buttonNumber0_Click(object sender, EventArgs e)
        {
            checkFirst(sender, new EventArgs());
            label1.Text += "0";
        }
        private void buttonDivide_Click(object sender, EventArgs e)
        {
            if (number1 != 0)
            {
                buttonResult_Click(sender, new EventArgs());
            }
            if (isOperated)
            {
                label2.Text = "";
            }
            process = 1;
            number1 = double.Parse(label1.Text);
            label2.Text += label1.Text + "÷";
            isClearOn = true;
        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            if (number1 != 0)
            {
                buttonResult_Click(sender, new EventArgs());
            }
            if (isOperated)
            {
                label2.Text = "";
            }
            process = 2;
            number1 = double.Parse(label1.Text);
            label2.Text += label1.Text + "x";
            isClearOn = true;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (number1 != 0)
            {
                buttonResult_Click(sender, new EventArgs());
            }
            if (isOperated)
            {
                label2.Text = "";
            }
            process = 3;
            number1 = double.Parse(label1.Text);
            label2.Text += label1.Text + "+";
            isClearOn = true;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (number1 != 0)
            {
                buttonResult_Click(sender, new EventArgs());
            }
            if (isOperated)
            {
                label2.Text = "";
            }
            process = 4;
            number1 = double.Parse(label1.Text);
            label2.Text += label1.Text + "-";
            isClearOn = true;
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            switch (process)
            {
                case 1:
                    number1 /= double.Parse(label1.Text);
                    break;
                case 2:
                    number1 *= double.Parse(label1.Text);
                    break;
                case 3:
                    number1 += double.Parse(label1.Text);
                    break;
                case 4:
                    number1 -= double.Parse(label1.Text);
                    break;
                default:
                    break;
            }
            label2.Text += label1.Text + "=";
            label1.Text = number1.ToString();
            number1 = 0;
            isOperated = true;
        }
    }
}
