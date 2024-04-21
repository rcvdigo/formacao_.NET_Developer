using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models
{
    public class Professor(string nome, int idade, decimal salario) : Pessoa(nome, idade)
    {
        public decimal Salario { get; set; } = salario;

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos, e sou um professor com salário de: {Salario:C}!");
        }
    }
}