namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            lblMedia.Text = lblResultado.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nota1 = int.Parse(tbM1.Text);
            int nota2 = int.Parse(tbM2.Text);
            int nota3 = int.Parse(tbM3.Text);

            if ((nota1 < 0 || nota1 > 20) ||
                (nota2 < 0 || nota2 > 20) ||
                (nota3 < 0 || nota3 > 20)
                )
            {
                // se alguma das notas estiver fora
                lblMedia.Text = "Notas fora do intervalo.";
            }
            else
            {
                // se todas as notas estiverem ok

                double media = (nota1 + nota2 + nota3) / 3.0;
                lblMedia.Text = media.ToString();

                int notaMin = Math.Min(nota1, Math.Min(nota2, nota3));

                double media2melhores = (nota1 + nota2 + nota3 - notaMin) / 2.0;

                if(media2melhores > 10)
                {
                    lblResultado.Text = "Aprovado!";
                }
                else {
                    if(nota1 == 0 || nota2 == 0 || nota3 == 0)
                    {
                        lblResultado.Text = "Chumbado!";
                    }
                    else
                    {
                        if(nota1>=15 || nota2 >=15 || nota3 >= 15)
                        {
                            lblResultado.Text = "Aprovado!";
                        }
                        else
                        {
                            lblResultado.Text = "Chumbado!";
                        }
                    }
                }
            }
        }
    }
}
