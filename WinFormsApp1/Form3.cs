namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double velocidade = double.Parse(velocidade_textBox.Text); // em km/h
            double massa = double.Parse(massa_textBox.Text);

            velocidade = velocidade * 0.27778; // m/s

            double energia = (massa * velocidade * velocidade) / 2.0; // em joule
            double energiaEmKwh = energia / 3600000;
            bool energiaBaixa = energia < 1000;

            joule_label.Text = energia + " (J)";
            kwh__label.Text = energiaEmKwh + " (kWh)";


            
            if (!energiaBaixa)
            {
                // cuidado
            }
        }
    }
}
