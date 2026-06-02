using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PRACTICA_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);

            int sum = num1 + num2;

            label3.Text = "Sum = " + sum;
        }
    }
}
