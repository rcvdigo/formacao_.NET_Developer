# Conhecendo a Organização de um Programa C#

## Na versão .NET5 a classe main é explicita e obrigatória:
- Método Main:

```C#
using System;

namespace ExemploFundamentos.NET5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
```

## Já nas versões acima, exemplo .NET6 a classe main é implicita ou seja não é obrigatória, porém ela é gerada automáticamente na compilação, podendo escrever o programa direto:
- Exemplo:

```C#
Console.WriteLine("Hello World!");
```


DOTNET
|----- Program.cs

Esse arquivo é a nossa classe!

DOTNET
|----- dotnet.csproj

Esse arquivo arquivo de projeto do C# contém informações enssenciais para o projeto conhecido como metadados usando xml.
.csproj: contém informações referente a um projeto (build, debug, versão)

DOTNET
|----- .sln
Contém informações que carregam um agrupamento de projetos


DOTNET
|----- obj

Se refere aos arquivos de Debug, arquivos de compilação.

DOTNET
|----- bin

Pasta de arquivos binários, compilados, .exe, .dll e .pdb.

# Conceito de Classe

```mermaid
classDiagram
    class Pessoa {
        + Nome: String
        + Idade: Int
        + apresentar() void
    }
```

```C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar() 
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos");
        }
    }
}
```

# Usando namespaces

- No programa principal Program.cs, para instanciarmos a classe Pessoa iremos precisar fazer o uso de namespaces.
- Desta forma no Program.cs no inicio é necessário colocar a palavra [using] e o nome do namespace [dotnet.Models], ex:

```C#
// Criando uma nova Instancia da Classe Pessoa no Program.cs
using dotnet.Models;

Pessoa pessoa1 new Pessoa();
```

- Sendo assim podemos ter classes com o mesmo nome desde que o NameSpace seja diferente.

# Usando a classe Pessoa

```C#
// Criando uma nova Instancia da Classe Pessoa no Program.cs
using dotnet.Models;

Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Rodrigo";
pessoa1.Idade = 18;
pessoa1.Apresentar();
```

# Cases

![image.png](attachment:image.png)

- Em C# se utiliza camelCase ou PascalCase.
- Nome de classes sempre em PascalCase!!!
- Nome de propriedades (atributos) da classe também em PascalCase!!!
- Nome de métodos (Funcoes, Procedimentos) da classe também em PascalCase!!!
- Nome de variáveis são em camelCase ex pessoaUm!!!
- Abreviações para os nomes de métodos, classes, propriedades e variáveis não são recomendadas em C#.
- Também não é recomendável utilizar caracteres especiais em nomes de métodos, classes, propriedades e variáveis exceto o Underline (_).
- Valores monetários é recomendável utilizar o tipo decimal.

# Tipos de dados

![image.png](attachment:image-2.png)<br/>


# Operador de atribuição

![image.png](attachment:image-3.png)

# Converter tipo de dados (Cast ou Casting)

- Em C# é possível fazer isso usando a classe Convert.ToInt32("5") ou também usando int.Parse("5").
- Ou seja ou usa o Convert ou usa o tipo do dado mais o método Parse().
- Isso é chamado de Cast ou Casting.
- Qual a diferença entre os dois?
    - A principal diferença entre eles é o tratamento do valores Nulos.
    - Quando se utiliza o Convert ele trata o dado do tipo nulo e converte para 0.
    - Já o método Parse gera uma Exception dando erro no programa em tempo de execução.
- Casting implícito:
```c#
int a = 5;
double b = a;
```
Isso é um Casting implícito!!!


# Operadores condicionais (if, else, switch case)

```C#
// IF e ELSE
int a = 5;
int b = 10;

if (a >= b)
{
    Console.WriteLine($"{a} é maior ou igual a {b}.");
}
else
{
    Console.WriteLine($"{a} é menor que {b}.");
}

// Podemos fazer o IF inline:
Console.WriteLine($"A é menor que B? {a > b}"); // Saída será False.

// IF Aninhado
int a = 5;
int b = 10;

if (a > b)
{
    Console.WriteLine($"{a} é maior que {b}.");
}
else if (b == a)
{
    Console.WriteLine("Os valores são iguais.");
}
else
{
    Console.WriteLine($"{a} é menor que {b}.");
}

// input no C# é Console.ReadLine(); Podemos fazer desta forma também:
Console.WriteLine("Digite uma letra:");
string letra = Console.ReadLine();

if (letra == "a" ||
    letra == "e" ||
    letra == "i" ||
    letra == "o" ||
    letra == "u")
{
    Console.WriteLine("Vogal.");
}
else
{
    Console.WriteLine("Não é Vogal.");
}

// Ou podemos fazer o switch Case
switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal.");
        break;
    default:
        Console.WriteLine("Não é Vogal.");
        break;
}
```

# Operadores lógicos (&&, ==, <=, >=, ||, !)

- && : E;
- == : Igualdade;
- <= : Menor ou Igual;
- >= : Maior ou Igual;
- || : Ou;
- ! :  Não;

# Incremento e Decremento

- variavel++;
- ++variavel;
- variavel--;
- --variavel;

# Estrutura de Repetição

```C#
// FOR -->

for (int i = 0; i < 3; i++)
{
    Console.Write(i + " ");
}
// Saída: 0 1 2

// ====================================================================================== //

// DO WHILE -->

bool usuarioNaoLogado = true;
do
{
    Console.WriteLine("Informe seu e-mail: ");
    string emailInformado = Console.ReadLine();
    // Lógica para verificar se o usuário está logado
    // ...
    // Se o usuário estiver logado, defina usuarioNaoLogado como false
} while (usuarioNaoLogado);

// ====================================================================================== //

// WHILE DO -->

int num = 1;
while (num <= 10)
{
    if (num % 2 == 0)
    {
        Console.Write(num + " ");
    }
    num++;
}
// Saída: 2 4 6 8 10

// ====================================================================================== //
```


# Arrays

- O array é uma estrutura de dados que armazena valores do mesmo tipo, com um tamnho fixo.

1. int[] array = new int[4];
2. int[] array = new int[]{42,75,74,61};
3. string[] nomes = {"Jan, "Fev};

- Índice: É a posição de um determinado valor de um array, sempre começando com zero.

![image-4.png](attachment:image-4.png)

1. int elemento = array[0];
// Elemento receberia o valor igual 42.
2. array[0] = 42;
// A posição 0 do array receberia o valor igual a 42, substituindo o valor que lá existia.


```C#
// Trabalhando com Arrays

int[] arrayInteiros = new int[3];

arrayInteiros[0] = 1;
arrayInteiros[1] = 2;
arrayInteiros[2] = 3;

Console.WriteLine("\nFOR COMUM: \n");

for (int contador = 0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine(
        $"Posição Nº: {contador} - Valor = {arrayInteiros[contador]}"
        );
}
```

# Usando o FOREACH

- Serve para percorrer uma coleção ou listas sem a necessidade de utilizar contador, um método para facilitar percorrer listas ou coleções.

```C#
// Trabalhando com Arrays

int[] arrayInteiros = new int[3];

arrayInteiros[0] = 1;
arrayInteiros[1] = 2;
arrayInteiros[2] = 3;

Console.WriteLine("\nFOREACH: \n");

foreach(int valor in arrayInteiros)
{
    int posicao = Array.IndexOf(arrayInteiros, valor);

    Console.WriteLine(
        $"Posição Nº: {posicao} - Valor = {valor}"
    );
}

```

# Redimensionar o tamanho de um array

- Para redimensionar um array podemos usar a classe Array e seu método Resize, ex:

```C#
// Redimensionando Arrays

int[] arrayInteiros = new int[3];

arrayInteiros[0] = 1;
arrayInteiros[1] = 2;
arrayInteiros[2] = 3;

Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);
// Após está ação o arrayInteiros terá seu tamanho dobrado para arrayInteiros[8]
// Este método resize, nada mais faz que, copiar o array atual, em seguida cria um novo com um novo tamanho e coloca os valores copiados do array antigo no novo.

// Fazendo manualmente o que o método Resize faz:

int [] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);
```

# Usando listas em C#

- Nas listas não precisamos definir o tamanho obrigatóriamente como um array.

```C#
// Criando uma lista em C#
List<string> listaString = new List<string>();
```

# Comentários
- Os comentários servem para documentar o seu código,
explicando um determinado método ou execução.

- Auxiliam outros programadores a entender o que está acontecendo.

## Tipos de comentários em C#

- Comentários com '//' é representado em uma única linha.
- Comentários com '/*COMENTARIOS*/' é representado em várias linhas.
- Comentários com '<summary>' permite documentar classes, métodos, parâmetros, etc.

# Propiedades, métodos e Construtores

- Uma propriedade é um membro que oferece um mecanismo flexível para ler, gravar ou calcular o valor de um campo particular.

# Exemplos:

```C#

namespace PropriedadesMetodosConstrutores.Models
{
    public class Pessoa
    {
        private string _nome;
        public string Nome 
        { 
            get
            {
                return _nome.ToUpper();
            }

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
        private int _idade;
        public int Idade 
        {
            get
            {
                return _idade;
            }

            set
            {
                if (value <= 0 || value > 130)
                {
                    throw new ArgumentOutOfRangeException("A idade deve estar acima de 0 e menor que 130.");
                }
                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine(
                $"""
                Nome: {Nome}
                Idade: {Idade}
                """
            );
        }
    }
}

```

# Usando body expressions (forma resumida para ficar mais legivel o get e set)

- Quando se tem apenas uma linha podemos fazer assim: get => _nome.ToUpper();

```C#

namespace PropriedadesMetodosConstrutores.Models
{
    public class Pessoa
    {
        private string _nome;
        public string Nome 
        { 
            get => _nome.ToUpper();

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
        private int _idade;
        public int Idade 
        {
            get => _idade;

            set
            {
                if (value <= 0 || value > 130)
                {
                    throw new ArgumentOutOfRangeException("A idade deve estar acima de 0 e menor que 130.");
                }
                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine(
                $"""
                Nome: {Nome}
                Idade: {Idade}
                """
            );
        }
    }
}

```

# Diferenças entre campos e propriedades

- Campos não possuem get e set, exemplo:
    ```C#
    private string _nome;
    private int _idade;
    ```
- As propriedades possuem o get e set, exemplo:
    ```C#
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
    ```


# Tipos de encapsulamento

- public: Qualquer um pode acessar.
- private: Apenas a classe tem acesso, ou seja ela esta protegida de alterações externas.

# Métodos

- Um método é um bloco de código que contém uma série de instruções.

# Contrutores

- Os construtores permitem que o programador defina valores padrão, limite a instanciação e grave códigos flexíveis fáceis de ler.

- Por convenção vem logo após o nome da classe, e tem o mesmo nome da classe seguido de parenteses "()".

- Em C# podemos ter mais de um construtor disponivel na classe.

```C#
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
        // PROPRIEDADE = CAMPO
        Nome = nome;
        Sobrenome = sobrenome;
    }
}
```

# UML

![image-5.png](attachment:image-5.png)

# Representação em código do esquema UML acima

- Classe Pessoa:
```C#
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
```

- Classe Curso:
```C#
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
            foreach (Pessoa aluno in Alunos)
            {
                Console.WriteLine(aluno.NomeCompleto);
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
```

- Programa Main:
```C#
using PropriedadesMetodosConstrutores.Models;

Pessoa p1 = new Pessoa(nome: "Rodrigo", sobrenome: "Camurça");
Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome: "Neves Queiroz");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(aluno: p1);
cursoDeIngles.AdicionarAluno(aluno: p2);

cursoDeIngles.ListarAlunos();

Console.WriteLine(
    $"""
    
    Quantidade de alunos matriculados no curso de:
    {cursoDeIngles.Nome} = {cursoDeIngles.QuantidadeAlunosMatriculados()}

    """
);
```

# Concatenação de string (Interpolação)

- Interpolação:
    ```C#
    Console.WriteLine(
                    $"""
                    Posição: {Alunos.IndexOf(aluno)+1}
                    Valor: {aluno.NomeCompleto}
                    """
                );
    ```

- Concatenação:
    ```C#
    string texto = "\nNº " + (Alunos.IndexOf(aluno)+1) + " " + aluno.NomeCompleto + "\n";


    Console.WriteLine(
        "USANDO CONCATENAÇÃO: " + texto 
    );
    ```

- Representação de formatação de Moeda:
```C#
decimal moeda = 1582.40M;
Console.WriteLine(
        $"{moeda:C}" // R$ 1.582,40
        $"{moeda:N}" // 1.582,40
        $"{moeda:C}" // R$ 1.582,4
        $"{moeda:N2}" // 1.582,4
        $"{moeda:P1}" // 1.582,4%
    ); // O que vem depois do : é o tipo de formatação C = Currency.
```

- Formatando o tipo DateTime:
```C#
DateTime data = DateTime.Now;
DateTime dataDois = DateTime.Parse("17/04/2022 18:00");
Console.WriteLine(data.ToString("dd/MM/yyyy"));
Console.WriteLine(data.ToShortDateString());
Console.WriteLine(data.ToShortTimeString());
Console.WriteLine(dataDois.ToShortDateString());
```

# Tratamento de Erros e Exceções

- Estrutura de exemplo:
    ```C#
    try
    {
        Console.WriteLine("Executa esse trecho de código, se cair em algum erro vai para o bloco abaixo do catch.");
    }
    catch(FileNotFoundException fnfe)
    {
        Console.WriteLine($"Outro tipo de erro: {fnfe.Message}");
    }
    catch(Exception ex)
    {
        Console.WriteLine($"Se cair em alguma exceção este bloco é executado. MENSAGEM DE ERRO: {ex.Message}");
    }
    finally
    {
        Console.WriteLine("O bloco finally é executado em seguida após a execução de um try ou de um catch");
    }
    ```

- Usando o Throw, que serve para lançar uma execeção:
    ```C#
    throw new Exception("Ocorreu uma exceção");
    ```

# Estruturas de dados Fila(Queue-FIFO), Pilha(Stack-LIFO) e Dictionary

- Fila:

    ```C#
    Queue<int> fila = new Queue<int>();
    fila.Enqueue(1);
    fila.Enqueue(4);
    fila.Enqueue(6);
    fila.Enqueue(8);

    foreach(int item in fila)
    {
        Console.WriteLine(item);
    }

    Console.WriteLine($"\nRemovendo o elemento: {fila.Dequeue()}\n");

    fila.Enqueue(10);

    foreach(int item in fila)
    {
        Console.WriteLine(item);
    }
    ```

- Pilha:

    ```C#
    Stack<int> pilha = new Stack<int>();

    pilha.Push(42);
    pilha.Push(75);
    pilha.Push(74);
    pilha.Push(61);

    foreach(int item in pilha)
    {
        Console.WriteLine(item);
    }

    Console.WriteLine($"\nRemovendo o elemento: {pilha.Pop()}\n");

    pilha.Push(10);

    foreach(int item in pilha)
    {
        Console.WriteLine(item);
    }
    ```

- Dictionary:

    ```C#
    Dictionary<string, string> dicionario = new Dictionary<string, string>();

    dicionario.Add("SP", "São Paulo");
    dicionario.Add("BA", "Bahia");
    dicionario.Add("MG", "Minas Gerais");

    // Removendo um valor ->
    dicionario.Remove("SP");

    foreach (var item in dicionario)
    {
        Console.WriteLine($"Chave: {item.Key} Valor: {item.Value}");
    }
    ```

# Tuplas

- Tuplas fornece sintaxe concisa para agrupar vários elementos de dados em uma estrutura de dados leve.

- Como declarar uma tupla:

    ```C#
    (int Id, string Nome, string Sobrenome) tupla = (1, "Rodrigo", "Camurça");
    ValueTuple<int, string, string> outroExemploTupla = (1, "Rodrigo", "Camurça");
    var maisUmExemplo = Tuple.Create(1, "Rodrigo", "Camurça");

    Console.WriteLine(
        $"""
        ID: {tupla.Id}
        NOME: {tupla.Nome}
        SOBRENOME: {tupla.Sobrenome}

        Outro Exemplo:
        ID: {outroExemploTupla.Item1}
        NOME: {outroExemploTupla.Item2}
        SOBRENOME: {outroExemploTupla.Item3}

        Outro Exemplo:
        ID: {maisUmExemplo.Item1}
        NOME: {maisUmExemplo.Item2}
        SOBRENOME: {maisUmExemplo.Item3}
        """
    );
    ```

# IF Ternário

```C#
var numero = 3;

Console.WriteLine($"O número {numero} é " + (numero % 2 == 0 ? "par" : "ímpar"));
```

# Nuget, serializar e atributos no C#

- Gerenciador de pacotes
    -   O que é um pacote?
        - Um pacote é um conjunto de códigos úteis, que possibilita o compartilhamento e reuso do código.

- __Nuget__ é um gerenciador de pacotes, que permite desenvolvedores compartilharem códigos e bibliotecas: ![alt text](nuget.png)

- Instalando pacotes no VScode:
    -   dotnet add package Newtonsoft.Json --version 13.0.3

# Serialização de dados

- O que é serialização e deserialização?

- O processo de serializar consiste em transformar objetos em um fluxo de bytes para seu armazenamento ou transmissão: ![alt text](serializacao.png)

- __JSON__ JavaScript Notation Object é um formato de texto que segue a sintaxe do javascript, muito usado para transmitir dados entre aplicações.

- Exemplo de serialização:
    - 
    ```C#
    using Newtonsoft.Json;
    
    Vendas v1 = new(id: 1, produto: "Pão", preco: 25.00M);

    string serializacao = JsonConvert.SerializeObject(v1, Formatting.Indented);

    Console.WriteLine(serializacao);
    ```