using Calculadora.Services;

CalculadoraImp calculadora = new();

int num1 = 5;
int num2 = 10;
int num3 = 6;
int num4 = 7;

Console.WriteLine($"{num1} + {num2} = {calculadora.Somar(num1, num2)}");

Console.WriteLine($"O {num3} é par? {calculadora.IsPar(num3)}");

Console.WriteLine($"O {num4} é par? {calculadora.IsPar(num4)}");