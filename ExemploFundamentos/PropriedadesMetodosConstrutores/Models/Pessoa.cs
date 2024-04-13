using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropriedadesMetodosConstrutores.Models
{
    public class Pessoa
    {

        // Construtor 1
        public Pessoa()
        {}

        // Construtor 2
        public Pessoa(
            string nome,
            string sobrenome
        )
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        // Campos
        private string _nome;
        private int _idade;

        // Propriedades
        public string Nome 
        { 
            get => _nome.ToUpper(); // Usando Body Expressions

            set
            {
                if (value == null || value == "")
                {
                    #pragma warning disable CA2208
                    throw new ArgumentNullException("O nome não pode ser vazio.");
                    #pragma warning restore CA2208
                }
                _nome = value; // Atribuir o valor do nome após validação de vazio.
            } 
        }
        public int Idade 
        {
            get => _idade; // Usando Body Expressions

            set
            {
                if (value <= 0 || value > 130)
                {
                    throw new ArgumentOutOfRangeException("A idade deve estar acima de 0 e menor que 130.");
                }
                _idade = value;
            }
        }
        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        // Métodos
        public void Apresentar()
        {
            Console.WriteLine(
                $"""
                Nome: {NomeCompleto}
                Idade: {Idade}
                """
            );
        }
    }
}