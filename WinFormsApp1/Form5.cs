namespace WinFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();

            lblHaNegativos.Text = lblPrimeiro.Text = lblUltimo.Text = string.Empty;
        }

        int primeiro, ultimo;
        int contador = 0;
        int contadorNegativos = 0;

        private void btnGo_Click(object sender, EventArgs e)
        {
            int n = int.Parse(tbNumero.Text);

            if (n == -1)
            {
                if (contador < 4)
                {
                    MessageBox.Show("Ainda só li " + contador + " número(s). Preciso de ler 4.");
                }
                else
                {
                    // programa vai terminar
                    lblHaNegativos.Text = (contadorNegativos > 0) + "";
                    // para imprimimr o contador de negativos
                    //haNegativos_label.Text = contadorNegativos + "";
                    lblPrimeiro.Text = primeiro + "";
                    lblUltimo.Text = ultimo + "";
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

            lbNums.Items.Add(n);

            contador++;
        }
    }
}
