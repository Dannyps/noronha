namespace WinFormsApp1
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valorIncial, taxaJuro;
            int prazo;

            valorIncial = double.Parse(valorInicial_textBox.Text);
            taxaJuro = double.Parse(taxaJuro_textBox.Text);
            prazo = int.Parse(prazo_textBox.Text);

            double montante = valorIncial * Math.Pow(1 + (taxaJuro)/100.0, prazo);

            montanteFinal.Text = montante.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
