namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            lblJoule.Text = lblKwh.Text = string.Empty;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double velocidade = double.Parse(tbVelocidade.Text); // em km/h
            double massa = double.Parse(tbMassa.Text);

            velocidade = velocidade * 0.27778; // m/s

            double energia = (massa * velocidade * velocidade) / 2.0; // em joule
            double energiaEmKwh = energia / 3600000;
            bool energiaBaixa = energia < 1000;

            lblJoule.Text = energia + " (J)";
            lblKwh.Text = energiaEmKwh + " (kWh)";

            if (!energiaBaixa)
            {
                MessageBox.Show("Cuidado! Energia baixa!", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
