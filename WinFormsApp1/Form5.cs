namespace WinFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void numero_Enter(object sender, EventArgs e)
        {
            Console.WriteLine("x");
        }

        int primeiro, ultimo;
        int contador = 0;
        int contadorNegativos = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(numero.Text);

            if (n == -1)
            {
                if (contador < 4)
                {
                    MessageBox.Show("Ainda só li " + contador + " número(s). Preciso de ler 4.");
                }
                else
                {
                    // programa vai terminar
                    haNegativos_label.Text = (contadorNegativos > 0) + "";
                    // para imprimimr o contador de negativos
                    //haNegativos_label.Text = contadorNegativos + "";
                    primeiro_label.Text = primeiro + "";
                    ultimo_label.Text = ultimo + "";
                }
                return;
            }

            if (contador == 0)
            {
                primeiro = n;
            }

            ultimo = n;

            if (n < 0)
            {
                contadorNegativos++;
            }

            listBox1.Items.Add(n);

            contador++;
        }
    }
}
