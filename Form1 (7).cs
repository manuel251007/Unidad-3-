namespace PRACTICA_8_USANDO_DO_WHILE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            const double pi = 3.141592;
            double radio, area, volumen;


            do
            {
                radio = double.Parse(txtRadio.Text);

                if (radio <= 0)
                {
                    MessageBox.Show("Ingresa un número mayor a 0");
                    return;
                }

            } while (radio <= 0);

            // Fórmulas
            area = 4 * pi * radio * radio;
            volumen = 4.0 / 3.0 * pi * Math.Pow(radio, 3);

            // Mostrar resultados
            txtArea.Text = area.ToString();
            txtVolumen.Text = volumen.ToString();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtRadio.Clear();
            txtArea.Clear();
            txtVolumen.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double baseT, altura, area;

            baseT = double.Parse(txtBase.Text);
            altura = double.Parse(txtAltura.Text);


            while (baseT <= 0 || altura <= 0)
            {
                MessageBox.Show("Valores incorrectos");
                return;
            }

            area = (baseT * altura) / 2;

            this.label11.Text = area.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBase.Clear();
            txtAltura.Clear();
            txtAreaTri.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double lado = double.Parse(txtLado.Text);
            double area = 0;
            double volumen = 0;


            for (int i = 0; i < 1; i++)
            {
                area = 6 * lado * lado;
                volumen = lado * lado * lado;
            }

            // Mostrar
            txtAreaCubo.Text = area.ToString("F2");
            txtVolumenCubo.Text = volumen.ToString("F2");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtAreaCubo.Clear();
            txtVolumenCubo.Clear();
            txtLado.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double radio = double.Parse(txtRadioCil.Text);
            double altura = double.Parse(txtAlturaCil.Text);

            double volumen = Math.PI * radio * radio * altura;

            txtVolumenCil.Text = volumen.ToString("F2");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtAreaCubo.Clear();
            txtVolumenCubo.Clear();
            txtLado.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            double D = double.Parse(txtDmayor.Text);
            double d = double.Parse(txtDmenor.Text);

            double area = (D * d) / 2;

            txtAreaRombo.Text = area.ToString("F2");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtDmayor.Clear();
            txtDmenor.Clear();
            txtAreaRombo.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double lado, area, volumen;

            if (!double.TryParse(txtLadoOct.Text, out lado))
            {
                MessageBox.Show("Ingresa un número válido");
                return;
            }

            area = 2 * Math.Sqrt(3) * lado * lado;
            volumen = (Math.Sqrt(2) / 3) * Math.Pow(lado, 3);

            txtAreaOct.Text = area.ToString("F2");
            txtVolumenOct.Text = volumen.ToString("F2");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtLadoOct.Clear();
            txtAreaOct.Clear();
            txtVolumenOct.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            double baseT, altura, area;

            if (!double.TryParse(txtBase.Text, out baseT) ||
                !double.TryParse(txtAltura.Text, out altura))
            {
                MessageBox.Show("Ingresa valores válidos");
                return;
            }

            area = (baseT * altura) / 2;

            txtAreaTri.Text = area.ToString("F2");
        }

        private void txtBase_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
