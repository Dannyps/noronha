namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            bool haDoisParesComOMesmoValorAbsoluto = false;

            bool err = int.TryParse(tbNum1.Text, out int numero1);
            err &= int.TryParse(tbNum2.Text, out int numero2);
            err &= int.TryParse(tbNum3.Text, out int numero3);
            err &= int.TryParse(tbNum4.Text, out int numero4);

            if (err)
            {
                MessageBox.Show("Erro na conversão", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
                MessageBox.Show("Há pelo menos dois números pares com o mesmo valor absoluto.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Não há dois números pares com o mesmo valor absoluto.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}