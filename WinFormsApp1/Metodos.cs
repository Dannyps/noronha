using System.Text;

namespace WinFormsApp1
{
    public partial class Metodos : Form
    {
        public Metodos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var index = int.Parse(textBox1.Text);

            var s = new StringBuilder();
            for (int i = 0; i <= index; i++)
            {
                s.Append($"{i}: {fibonacci75(i)}\n"); 
            }

            label1.Text = s.ToString();
        }

        int fibonacci75(int index)
        {
            if (index <= 0) return 0;
            if (index == 1) return 1;

            int a = 0, b = 1, c = 0;
            for (int i = 2; i <= index; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }

        void colocaMaximo81(ref int um, ref int dois, ref int tres)
        {
            var max = Math.Max(um, Math.Max(dois, tres));
            um = max;
            dois = max;
            tres = max;
        }

        int Sum65(int a, int b)
        {
            var soma = a + b;
            if (soma < 0) return 0;
            return soma;
        }

        bool ePrimo78(int numero)
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



        // método
        // 1. tipo de retorno
        // 2. parametros
        // 3. body
    }
}
