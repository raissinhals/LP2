using System;

namespace Pclasses
{
    public class Horista : Empregado
    {
        public double ValorHora { get; set; }
        public int HorasTrabalhadas { get; set; }

        public Horista(string nome, int matricula, double valorHora, int horasTrabalhadas)
            : base(nome, matricula)
        {
            ValorHora = valorHora;
            HorasTrabalhadas = horasTrabalhadas;
        }

        public override double CalcularSalario()
        {
            return ValorHora * HorasTrabalhadas;
        }

        public override void ExibirDados()
        {
            base.ExibirDados();
            Console.WriteLine($"Tipo: Horista");
            Console.WriteLine($"Horas Trabalhadas: {HorasTrabalhadas}");
            Console.WriteLine($"Valor da Hora: R$ {ValorHora:F2}");
            Console.WriteLine($"Salário: R$ {CalcularSalario():F2}");
        }
    }
}
