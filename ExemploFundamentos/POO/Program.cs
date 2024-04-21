using POO.interfaces;
using POO.Models;

// ContaCorrente c1 = new(numero: 123456, saldo: 100M);

// Console.WriteLine(c1.Numero);
// c1.Sacar(valor: 10);
// c1.ExibirSaldo();

// Aluno aluno = new(nome: "Rodrigo", idade: 29, nota: 10);
// aluno.Apresentar();
// Professor professor= new(nome: "Buta", idade: 25, salario: 1857.55M);
// professor.Apresentar();

// Corrente contaCorrente = new();
// contaCorrente.Creditar(500);
// contaCorrente.ExibirSaldo();

ICalculadora calc = new Calculadora();
Console.WriteLine(calc.Dividir(1, 2));