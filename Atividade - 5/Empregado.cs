using System;

namespace Pclasses
{
    public class Empregado
    {
        public string Nome { get; set; }
        public int Matricula { get; set; }

        public Empregado(string nome, int matricula)
        {
            Nome = nome;
            Matricula = matricula;
        }

        public virtual void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Matrícula: {Matricula}");
        }

        public virtual double CalcularSalario()
        {
            return 0.0;
        }
    }
}
