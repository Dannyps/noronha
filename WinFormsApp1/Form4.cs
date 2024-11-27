namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool haDoisParesComOMesmoValorAbsoluto = false;

            int.TryParse(textBox1.Text, out int numero1);
            int.TryParse(textBox2.Text, out int numero2);
            int.TryParse(textBox3.Text, out int numero3);
            int.TryParse(textBox4.Text, out int numero4);

            if (numero1 % 2 == 0)
            {
                if (numero2 % 2 == 0 && Math.Abs(numero1) == Math.Abs(numero2)) haDoisParesComOMesmoValorAbsoluto = true;
                if (numero3 % 2 == 0 && Math.Abs(numero1) == Math.Abs(numero3)) haDoisParesComOMesmoValorAbsoluto = true;
                if (numero4 % 2 == 0 && Math.Abs(numero1) == Math.Abs(numero4)) haDoisParesComOMesmoValorAbsoluto = true;
            }
            if (numero2 % 2 == 0)
            {
                if (numero3 % 2 == 0 && Math.Abs(numero2) == Math.Abs(numero3)) haDoisParesComOMesmoValorAbsoluto = true;
                if (numero4 % 2 == 0 && Math.Abs(numero2) == Math.Abs(numero4)) haDoisParesComOMesmoValorAbsoluto = true;
            }
            if (numero3 % 2 == 0 && numero4 % 2 == 0)
            {
                if (Math.Abs(numero3) == Math.Abs(numero4)) haDoisParesComOMesmoValorAbsoluto = true;
            }

            // Resultado
            if (haDoisParesComOMesmoValorAbsoluto)
            {
                label1.Text = "Há pelo menos dois números pares com o mesmo valor absoluto.";
            }
            else
            {
                label1.Text = "Não há dois números pares com o mesmo valor absoluto.";
            }
        }
    }
}