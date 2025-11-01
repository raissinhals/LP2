using System;

namespace Pclasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Cadastro de Empregados ===\n");

            Mensalista m = new Mensalista("Raíssa", 101, 5000);
            Horista h = new Horista("Lucas", 102, 50, 160);

            Console.WriteLine("Dados do Mensalista:");
            m.ExibirDados();

            Console.WriteLine("\nDados do Horista:");
            h.ExibirDados();

            Console.ReadKey();
        }
    }
}
