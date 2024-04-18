using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices.Marshalling;
using System.Threading.Tasks;
using PropriedadesMetodosConstrutores.Models;

namespace PropriedadesMetodosConstrutores.Models
{
    /// <summary>
    /// É um objeto Curso
    /// </summary>
    public class Curso
    {
        // Propriedades
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        // Métodos
        /// <summary>
        /// Adiciona um aluno do objeto curso
        /// </summary>
        /// <param name="aluno">Parametro obrigatório, do tipo Pessoa aluno</param>
        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        /// <summary>
        /// Remove um aluno do objeto curso 
        /// </summary>
        /// <param name="aluno">Parametro obrigatório, do tipo Pessoa aluno</param>
        public void RemoverAluno(Pessoa aluno)
        {
            Alunos.Remove(aluno);
        }

        /// <summary>
        /// Lista o nome completo dos alunos matriculados no objeto curso
        /// </summary>
        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de {Nome}: \n");

            // Usando concatenação de strings
            foreach (Pessoa aluno in Alunos)
            {
                string texto = "\nNº " + (Alunos.IndexOf(aluno)+1) + " " + aluno.NomeCompleto + "\n";
                Console.WriteLine(
                    "USANDO CONCATENAÇÃO: " + texto 
                );
            }

            // Usando Interpolação de Strings
            foreach (Pessoa aluno in Alunos)
            {
                Console.WriteLine(
                    $"""
                    USANDO INTERPOLAÇÃO DE STRINGS:
                    
                    Posição: {Alunos.IndexOf(aluno)+1}
                    Valor: {aluno.NomeCompleto}
                    
                    """
                );
            }
        }


        /// <summary>
        /// Lista as matriculas dos alunos matriculados no objeto curso
        /// </summary>
        public void ObterAlunosMatriculados()
        {
            //TODO
        }


        /// <summary>
        /// Calcula a quantidade de alunos matriculados no objeto curso
        /// </summary>
        /// <returns>Retorna a quantidade de alunos matriculados no curso</returns>
        public int QuantidadeAlunosMatriculados()
        {
            return Alunos.Count();
        }
    }
}