namespace Taschenrechner_V2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            fieldOutput.Text = "";
            fieldInput.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            fieldInput.Text += btn.Text.ToString() + " ";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }
    }
}