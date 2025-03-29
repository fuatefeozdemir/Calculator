namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        bool shouldClearDisplay = false;
        bool isOperated = false;
        double number = 0;
        int process = 0;

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            if (shouldClearDisplay)
            {
                displayLabel.Text = "0";
                shouldClearDisplay = false;
            }
            if (displayLabel.Text == "0")
            {
                displayLabel.Text = "";
            }
            displayLabel.Text += ((Button)sender).Text;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (number != 0)
            {
                btnResult_Click(sender, new EventArgs());
            }
            if (isOperated)
            {
                historyLabel.Text = "";
            }
            process = 1;
            number = double.Parse(displayLabel.Text);
            historyLabel.Text += displayLabel.Text + "÷";
            shouldClearDisplay = true;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (number != 0)
            {
                btnResult_Click(sender, new EventArgs());
            }
            if (isOperated)
            {
                historyLabel.Text = "";
            }
            process = 2;
            number = double.Parse(displayLabel.Text);
            historyLabel.Text += displayLabel.Text + "x";
            shouldClearDisplay = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (number != 0)
            {
                btnResult_Click(sender, new EventArgs());
            }
            if (isOperated)
            {
                historyLabel.Text = "";
            }
            process = 3;
            number = double.Parse(displayLabel.Text);
            historyLabel.Text += displayLabel.Text + "+";
            shouldClearDisplay = true;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (number != 0)
            {
                btnResult_Click(sender, new EventArgs());
            }
            if (isOperated)
            {
                historyLabel.Text = "";
            }
            process = 4;
            number = double.Parse(displayLabel.Text);
            historyLabel.Text += displayLabel.Text + "-";
            shouldClearDisplay = true;
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if (number != 0)
            {
                btnResult_Click(sender, new EventArgs());
            }
            if (isOperated)
            {
                historyLabel.Text = "";
            }
            process = 5;
            number = double.Parse(displayLabel.Text);
            historyLabel.Text += displayLabel.Text + "%";
            shouldClearDisplay = true;
        }
        private void btnResult_Click(object sender, EventArgs e)
        {
            switch (process)
            {
                case 1:
                    number /= double.Parse(displayLabel.Text);
                    break;
                case 2:
                    number *= double.Parse(displayLabel.Text);
                    break;
                case 3:
                    number += double.Parse(displayLabel.Text);
                    break;
                case 4:
                    number -= double.Parse(displayLabel.Text);
                    break;
                case 5:
                    number %= double.Parse(displayLabel.Text);
                    break;
                default:
                    break;
            }
            historyLabel.Text += displayLabel.Text + "=";
            displayLabel.Text = number.ToString();
            number = 0;
            isOperated = true;
            shouldClearDisplay = true;
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (shouldClearDisplay)
            {
                displayLabel.Text = "0";
                shouldClearDisplay = false;
            }
            if (displayLabel.Text == "0")
            {
                displayLabel.Text = "";
            }

            if (displayLabel.Text.Length > 1)
            {
                displayLabel.Text = displayLabel.Text.Substring(0, (displayLabel.Text.Length - 1));
            }
            else
            {
                displayLabel.Text = "0";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            historyLabel.Text = "";
            displayLabel.Text = "0";
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(displayLabel.Text[0]) == "-")
            {
                displayLabel.Text = displayLabel.Text.Substring(1, (displayLabel.Text.Length) - 1);
            }
            else
            {
                displayLabel.Text = "-" + displayLabel.Text;
            }
        }
    }
}
