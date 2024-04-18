using System.Net.NetworkInformation;
using PropriedadesMetodosConstrutores.Models;
using Newtonsoft.Json;

DateTime dataAtual = DateTime.Now;

List<Vendas> listaDeVendas = [];
Vendas v1 = new(id: 1, produto: "Pão", preco: 25.00M, dataAtual);
Vendas v2 = new(id: 2, produto: "Pão Baguete", preco: 25.50M, dataAtual);

// Acionando objetos na lista
listaDeVendas.Add(v1);
listaDeVendas.Add(v2);

// Serialização do objeto para json
string serializacao = JsonConvert.SerializeObject(listaDeVendas, Formatting.Indented);

// Salvando arquivo .json
File.WriteAllText("Arquivos/vendas.json", serializacao);

// Lendo arquivo .json
string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// Deserialização
listaDeVendas = JsonConvert.DeserializeObject<List<Vendas>>(conteudoArquivo);

// Imprimindo no console
foreach (var item in listaDeVendas)
{
    Console.WriteLine(
        $"""

        ID: {item.Id}
        Produto: {item.Produto}
        Preco: {item.Preco}
        Data Da Venda: {item.DataVenda:dd/MM/yyyy HH:mm}
        """
    );
}


// Pessoa p1 = new Pessoa(nome: "Rodrigo", sobrenome: "Camurça");
// Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome: "Neves Queiroz");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(aluno: p1);
// cursoDeIngles.AdicionarAluno(aluno: p2);

// cursoDeIngles.ListarAlunos();

// Console.WriteLine(
//     $"""
    
//     Quantidade de alunos matriculados no curso de:
//     {cursoDeIngles.Nome} = {cursoDeIngles.QuantidadeAlunosMatriculados()}

//     """
// );


// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhas, quantidade) = arquivo.LerArquivo(caminho: "Arquivos/arquivoLeitura.txt");

// if (sucesso)
// {
//     Console.WriteLine($"Quantidade de linhas do arquivo: {quantidade}");
//     foreach (var linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("Não foi possivel ler o arquivo!".ToUpper());
// }
