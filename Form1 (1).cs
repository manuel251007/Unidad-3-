namespace PRACTICA_2_HELLO_MUNDO
{
    public partial class Hello : Form
    {
        public Hello()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "Hello, " + textBox1.Text + "!";
        }
    }
}
