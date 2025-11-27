namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BotonNumero_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (txtNumeroActual.Text.Length >= 16)
            {
                return;
            }

            txtNumeroActual.Text += btn.Text;
            Console.Write(txtNumeroActual.Text);
        }

        private void pasarNumeroOperacion(string signo)
        {
            txtOperacion.Text += " " + txtNumeroActual.Text + " " + signo;
            txtNumeroActual.Clear();
        }

        

        private void btSuma_Click(object sender, EventArgs e)
        {
            pasarNumeroOperacion(btSuma.Text);
        }

        private void btResta_Click(object sender, EventArgs e)
        {
            pasarNumeroOperacion(btResta.Text);
        }

        private void btMulti_Click(object sender, EventArgs e)
        {
            pasarNumeroOperacion(btMulti.Text);
        }

        private void btDivision_Click(object sender, EventArgs e)
        {
            pasarNumeroOperacion(btDivision.Text);
        }

        private void btUnario_Click(object sender, EventArgs e)
        {
            
        }

        private void btDecimal_Click(object sender, EventArgs e)
        {

        }

        private void btIgual_Click(object sender, EventArgs e)
        {

        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            txtNumeroActual.Text = "0";
            txtOperacion.Clear();
        }
    }
}
