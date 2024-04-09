// // Criando uma nova Instancia da Classe Pessoa
// using dotnet.Models;

// Pessoa pessoa1 = new Pessoa();
// Calculadora calculadoraBasica = new Calculadora();


// pessoa1.Nome = "Rodrigo";
// pessoa1.Idade = 18;
// pessoa1.Apresentar();

// string apresentacao = "Olá, seja bem vindo";

// int quantidade = 1;

// double altura = 1.80;

// decimal preco = 1.80M;

// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine(quantidade);
// Console.WriteLine(altura);
// Console.WriteLine(altura.ToString("0.00"));
// Console.WriteLine(preco);
// Console.WriteLine(condicao);

// Console.WriteLine("------------------");
// // Alterando o valor de uma variável sobrescrevendo
// quantidade = 10;
// Console.WriteLine(quantidade);

// // Usando o Struct DateTime
// //Um struct é um tipo de valor que é geralmente usado para 
// //representar um objeto leve que contém dados relacionados. 
// //Ao contrário das classes, que são tipos de referência, 
// //os structs são tipos de valor, o que significa que são 
// //armazenados diretamente na memória onde a variável está 
// //declarada.
// Console.WriteLine("------------------");
// DateTime dataAtual = DateTime.Now;
// Console.WriteLine(dataAtual);
// Console.WriteLine("------------------");
// Console.WriteLine("------------------");
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));
// Console.WriteLine("------------------");
// Console.WriteLine("------------------");
// Console.WriteLine(dataAtual.ToString("hh:mm:ss"));
// Console.WriteLine("------------------");
// // Para adicionar dias ou horas etc é necessário o uso de métodos ex:
// Console.WriteLine("------------------");
// Console.WriteLine(dataAtual.AddDays(5).ToString("dd/MM/yyyy"));
// Console.WriteLine("------------------");

// int a = 5;
// int b = 10;

// if (a > b)
// {
//     Console.WriteLine($"{a} é maior que {b}.");
// }
// else if (b == a)
// {
//     Console.WriteLine("Os valores são iguais.");
// }
// else
// {
//     Console.WriteLine($"{a} é menor que {b}.");
// }


// Console.WriteLine($"A é menor que B? {a > b}");

// Console.WriteLine("Digite uma letra:");
// string letra = Console.ReadLine() ?? string.Empty;

// if (letra == "a" ||
//     letra == "e" ||
//     letra == "i" ||
//     letra == "o" ||
//     letra == "u")
// {
//     Console.WriteLine("Vogal.");
// }
// else
// {
//     Console.WriteLine("Não é Vogal.");
// }

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal.");
//         break;
//     default:
//         Console.WriteLine("Não é Vogal.");
//         break;
// }

// calculadoraBasica.Somar(1, 2);
// calculadoraBasica.Subtrair(1, 2);
// calculadoraBasica.Multiplicar(1, 2);
// calculadoraBasica.Dividir(1, 2);
// calculadoraBasica.Potencia(5, 5);
// calculadoraBasica.Seno(30);
// calculadoraBasica.Coseno(30);
// calculadoraBasica.Tangente(30);

// int incremento = 0;
// Console.WriteLine(++incremento);

// int decremento = incremento;
// Console.WriteLine(--decremento);

// calculadoraBasica.Raiz(4);

// int numero = 10;

// for (int i = 0; i <= 10; i++)
// {
//     Console.WriteLine($"{numero} x {i} = {numero * i}");
// }

// Console.WriteLine("------------------------------------");
// Console.WriteLine("Digite um número para calcular o fatorial:");
// string fat = Console.ReadLine() ?? string.Empty;

// int resultado = 1;

// for (int i = 1; i <= Convert.ToInt32(fat); i++)
// {
//     resultado *= i;
//     Console.WriteLine($"{resultado}");

// }
// Console.WriteLine("------------------------------------");

// resultado = 1;

// while (resultado < Convert.ToInt32(fat))
// {
//     Console.WriteLine($"{resultado++}");
// }

// do
// {
//     Console.WriteLine($"Usando o Do While. {--resultado}");
// }
// while (resultado > 0);

using ExemploFundamentos.Common.Models;

Pessoa pessoa = new()
{
    Nome = "Rodrigo",
    Idade = 29
};

pessoa.Apresentar();

// MENU ITERATIVO
string opcao;
bool exibirMenu = true;

while (exibirMenu)
{
    // Ao escolher uma opção limpar o console
    // Console.Clear();

    // Opções disponiveis
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");

    // Capturar o Input do console digitado pelo usuario
    opcao = Console.ReadLine() ?? string.Empty;

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de cliente");
            break;

        case "2":
            Console.WriteLine("Busca de cliente");
            break;

        case "3":
            Console.WriteLine("Apagar de cliente");
            break;

        case "4":
            Console.WriteLine("Encerrar");
            exibirMenu = false;
            break;
        
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}