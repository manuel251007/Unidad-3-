namespace PRACTICA_7_CON_ESTRUCTURA_SELECTIVA_IF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double celsius, fahrenheit;

            celsius = double.Parse(textBox1.Text);

            if (celsius >= -273)
            {
                fahrenheit = (celsius * 9 / 5) + 32;
                textBox2.Text = fahrenheit.ToString();
                label6.Text = "Convirtiendo a Fahrenheit";
            }
            else
            {
                textBox2.Text = "Error";
                label6.Text = "Dato invalido";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double fahrenheit, celsius;

            fahrenheit = double.Parse(textBox1.Text);

            celsius = (fahrenheit - 32) * 5 / 9;

            textBox2.Text = celsius.ToString();
            label6.Text = "Convirtiendo a Celsius";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
