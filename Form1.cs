namespace Taschenrechner_V2
{
    public partial class Taschenrechner : Form
    {
        double number1;
        double number2;
        string operation;
        double sum;
        public Taschenrechner()
        {
            InitializeComponent();
        }
        private void buttonNumber_Click(object sender, EventArgs e)
        {
            Button buttonNumber = sender as Button;
            if (buttonNumber != null)
            {
                fieldInput.Text += buttonNumber.Text;
            }
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(fieldInput.Text))
            {
                number2 = double.Parse(fieldInput.Text);

                switch (operation)
                {
                    case "+":
                        sum = number1 + number2;
                        break;
                    case "-":
                        sum = number1 - number2;
                        break;
                    case "*":
                        sum = number1 * number2;
                        break;
                    case ":":
                        sum = number1 / number2;
                        break;
                }

                fieldOutput.Text = sum.ToString();
                fieldInput.Text = "";
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(fieldInput.Text))
            {
                number1 = double.Parse(fieldInput.Text);
                operation = "+";
                fieldInput.Clear();
            }
        }

        private void buttonComma_Click(object sender, EventArgs e)
        {
            if (!fieldInput.Text.Contains("."))
            {
                fieldInput.Text += ".";
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(fieldInput.Text))
            {
                number1 = double.Parse(fieldInput.Text);
                operation = "-";
                fieldInput.Clear();
            }
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(fieldInput.Text))
            {
                number1 = double.Parse(fieldInput.Text);
                operation = "*";
                fieldInput.Clear();
            }
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(fieldInput.Text))
            {
                number1 = double.Parse(fieldInput.Text);
                operation = ":";
                fieldInput.Clear();
            }
        }

        private void fieldInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void fieldOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            fieldInput.Clear();
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            fieldInput.Clear();
            fieldOutput.Clear();
            number1 = 0;
            number2 = 0;
            operation = "";
        }

    }
}