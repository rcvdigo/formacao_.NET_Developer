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