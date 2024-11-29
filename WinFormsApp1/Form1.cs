namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            lblMontanteFinal.Text = string.Empty;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double valorIncial, taxaJuro;
            int prazo;

            valorIncial = double.Parse(tbValorInicial.Text);
            taxaJuro = double.Parse(tbTaxaJuro.Text);
            prazo = int.Parse(tbPrazo.Text);

            double montante = valorIncial * Math.Pow(1 + (taxaJuro)/100.0, prazo);

            lblMontanteFinal.Text = montante.ToString();
        }
    }
}
