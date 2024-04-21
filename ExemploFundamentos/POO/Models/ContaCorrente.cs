using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models
{
    public class ContaCorrente(int numero, decimal saldo)
    {
        public int Numero { get; set; } = numero;
        private decimal Saldo = saldo;
        
        public void Sacar(decimal valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de: {valor:C} realizado com sucesso!");
                Console.WriteLine($"Saldo atualizado: {Saldo:C}");
            }
            else
            {
                Console.WriteLine($"Seu saldo: {Saldo:C} é insulficiente para realizar um saque de {valor:C}.");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo é: {Saldo}");
        }
    }
}