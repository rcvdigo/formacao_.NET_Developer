﻿using System.Net.NetworkInformation;
using PropriedadesMetodosConstrutores.Models;
using Newtonsoft.Json;


int numero = 3;
bool par = false;

par = numero.EhPar();

string mensagem = "O número " + numero + " " + "é " + (par ? "par" : "ímpar");

Console.WriteLine(mensagem);

// DateTime dataAtual = DateTime.Now;
// List<Vendas> listaDeVendas = [];
// Vendas v1 = new(id: 1, produto: "Pão", preco: 25.00M, dataVenda: dataAtual, desconto: null);
// Vendas v2 = new(id: 2, produto: "Pão Baguete", preco: 25.50M, dataVenda: dataAtual, desconto: 10M);

// // Adicionando objetos na lista
// listaDeVendas.Add(v1);
// listaDeVendas.Add(v2);

// // Serialização do objeto para json
// string serializacao = JsonConvert.SerializeObject(listaDeVendas, Formatting.Indented);

// // Salvando arquivo .json
// File.WriteAllText("Arquivos/vendas.json", serializacao);

// // Lendo arquivo .json
// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// // Deserialização
// listaDeVendas = JsonConvert.DeserializeObject<List<Vendas>>(conteudoArquivo);

// // Imprimindo no console
// foreach (var item in listaDeVendas)
// {
//     Console.WriteLine(
//         $"""

//         ID: {item.Id}
//         Produto: {item.Produto}
//         Preco: {item.Preco:C}
//         Data Da Venda: {item.DataVenda:dd/MM/yyyy HH:mm}
//         {(item.Desconto.HasValue ? $"Desconto de: {item.Desconto:C}" : "")}
//         """
//     );
// }

// // Extraindo propriedades especificas de um objeto
// // Criando um novo objeto de tipos anonimos
// var listaAnonima = listaDeVendas.Select(elemento => new { elemento.Produto, elemento.Preco });

// foreach (var item in listaAnonima)
// {
//     Console.WriteLine(
//         $"""

//         Produto: {item.Produto}
//         Preco: {item.Preco:C}
//         """
//     );
// }


// // EXEMPLO DE TIPO ANONIMO
// var tipoAnonimo = new { Nome = "Rodrigo",  Sobrenome = "Camurça", Altura = 1.80 };

// Console.WriteLine(
// $"""

// Nome: {tipoAnonimo.Nome}
// Sobrenome: {tipoAnonimo.Sobrenome}
// Altura: {tipoAnonimo.Altura}

// """
// );

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
