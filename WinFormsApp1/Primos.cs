namespace WinFormsApp1
{
    public partial class Primos : Form
    {
        public Primos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(textBox1.Text);
            label2.Text = isPrime(numero) ? "É primo." : "Não é Primo";
        }

        static bool isPrime(int numero)
        {
            if (numero == 1 || numero == 2 || numero == 3)
                return true;

            if (numero % 2 == 0)
                return false;

            double sqrt = Math.Sqrt(numero);

            for (int i = 3; i < sqrt; i += 2)
            {
                if (numero % i == 0)
                    return false;
            }

            return true;
        }
    }
}
