using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models
{
    public class Aluno(string nome, int idade, double nota) : Pessoa(nome, idade)
    {
        public double Nota { get; set; } = nota;

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos, e sou um aluno nota {Nota}!");
        }
    }
}