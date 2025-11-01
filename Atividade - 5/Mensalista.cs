using System;

namespace Pclasses
{
    public class Mensalista : Empregado
    {
        public double SalarioMensal { get; set; }

        public Mensalista(string nome, int matricula, double salarioMensal)
            : base(nome, matricula)
        {
            SalarioMensal = salarioMensal;
        }

        public override double CalcularSalario()
        {
            return SalarioMensal;
        }

        public override void ExibirDados()
        {
            base.ExibirDados();
            Console.WriteLine($"Tipo: Mensalista");
            Console.WriteLine($"Salário: R$ {CalcularSalario():F2}");
        }
    }
}
