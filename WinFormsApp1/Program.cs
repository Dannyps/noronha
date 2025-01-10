using System.Collections.Immutable;
using System.Reflection;
using System.Runtime.InteropServices;

namespace WinFormsApp1
{
    internal static class Program
    {

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            AllocConsole();
            ApplicationConfiguration.Initialize();
            var forms = Assembly.GetExecutingAssembly().ExportedTypes.Where(t => t.IsAssignableTo(typeof(Form))).ToImmutableArray();

            Console.WriteLine("Estão disponíveis os seguintes forms:");

            var i = 1;
            var fail = true;
            int formNumber = 0;
            foreach (var form in forms)
            {
                Console.WriteLine($"{i++}: {form.Name}");
            }

            if (args.Length > 0 && int.TryParse(args[0], out int number))
            {
                formNumber = number;
                if (formNumber <= 0 || formNumber > forms.Length)
                {
                    Console.WriteLine("O número inserido não corresponde a um Form. Por favor tente novamente.");
                    fail = true;
                }
                else
                {
                    fail = false;
                }
            }

            while (fail)
            {
                Console.WriteLine("Escolha um form para iniciar:");
                formNumber = int.Parse(Console.ReadLine()!);
                if (formNumber <= 0 || formNumber > forms.Length)
                    Console.WriteLine("O número inserido não corresponde a um Form. Por favor tente novamente.");
                else fail = false;
            }
            Application.Run(Activator.CreateInstance(forms[formNumber - 1]) as Form);
        }
    }
}