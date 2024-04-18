using PropriedadesMetodosConstrutores.Models;


LeituraArquivo arquivo = new LeituraArquivo();

var (sucesso, linhas, quantidade) = arquivo.LerArquivo(caminho: "Arquivos/arquivoLeitura.txt");

if (sucesso)
{
    Console.WriteLine($"Quantidade de linhas do arquivo: {quantidade}");
    foreach (var linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Não foi possivel ler o arquivo!".ToUpper());
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