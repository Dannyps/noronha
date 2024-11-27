using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        double nota1 = 2.5;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nota1 = int.Parse(textBox1.Text);
            int nota2 = int.Parse(textBox2.Text);
            int nota3 = int.Parse(textBox3.Text);

            if ((nota1 < 0 || nota1 > 20) ||
                (nota2 < 0 || nota2 > 20) ||
                (nota3 < 0 || nota3 > 20)
                )
            {
                // se alguma das notas estiver fora
                media_label.Text = "Notas fora do intervalo.";
            }
            else
            {
                // se todas as notas estiverem ok

                double media = (nota1 + nota2 + nota3) / 3.0;
                media_label.Text = media.ToString();

                int notaMin = Math.Min(nota1, Math.Min(nota2, nota3));

                double media2melhores = (nota1 + nota2 + nota3 - notaMin) / 2.0;

                if(media2melhores > 10)
                {
                    aprovado_label.Text = "Aprovado!";
                }
                else {
                    if(nota1 == 0 || nota2 == 0 || nota3 == 0)
                    {
                        aprovado_label.Text = "Chumbado!";
                    }
                    else
                    {
                        if(nota1>=15 || nota2 >=15 || nota3 >= 15)
                        {
                            aprovado_label.Text = "Aprovado!";
                        }
                        else
                        {
                            aprovado_label.Text = "Chumbado!";
                        }
                    }
                }
            }
        }
    }
}
