namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void tbxvalor1_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbxvalor2_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbxresultado_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnsumar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbxvalor1.Text, out int numero1) &&
                int.TryParse(tbxvalor2.Text, out int numero2))
            {
                int resultado = numero1 + numero2;
                tbxresultado.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Por favor validar números válidos en ambos campos");
            }
        }
    }
}