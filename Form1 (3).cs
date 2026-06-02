namespace PRACTICA_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c, d;

            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            c = int.Parse(textBox3.Text);
            d = int.Parse(textBox4.Text);

            textBox5.Text = d.ToString();
            textBox6.Text = c.ToString();
            textBox7.Text = b.ToString();
            textBox8.Text = a.ToString();
        }
    }
}
