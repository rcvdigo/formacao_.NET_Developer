using TestesUnitarios.Desafio.Console.Services;
using Xunit.Abstractions;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesListaTests
{
    private readonly ValidacoesLista _validacoes = new();
    private readonly ITestOutputHelper _output;
    
    public ValidacoesListaTests(ITestOutputHelper output)
    {
        _output = output;
    }

    [Fact]
    public void DeveRemoverNumerosNegativosDeUmaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var resultadoEsperado = new List<int> { 5, 9 };
        _output.WriteLine($"lista: {lista}");
        _output.WriteLine($"resultadoEsperado: {resultadoEsperado}");

        // Act
        var resultado = _validacoes.RemoverNumerosNegativos(lista);
        _output.WriteLine($"resultado: {resultado}");

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveConterONumero9NaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 9;
        _output.WriteLine($"lista: {lista}");
        _output.WriteLine($"numeroParaProcurar: {numeroParaProcurar}");

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);
        _output.WriteLine($"resultado: {resultado}");

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterONumero10NaLista()
    {
        //TODO: Implementar método de teste

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 10;
        _output.WriteLine($"lista: {lista}");
        _output.WriteLine($"numeroParaProcurar: {numeroParaProcurar}");

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);
        _output.WriteLine($"resultado: {resultado}");

        // Assert
        Assert.False(resultado);
    }

    //TODO: Corrigir a anotação [Fact]
    [Fact]
    public void DeveMultiplicarOsElementosDaListaPor2()
    {
        //TODO: Implementar método de teste

        // Arrange
        var lista = new List<int> { 5, 7, 8, 9 };
        var resultadoEsperado = new List<int> { 10, 14, 16, 18 };
        _output.WriteLine($"lista: {lista}");
        _output.WriteLine($"resultadoEsperado: {resultadoEsperado}");

        // Act
        var resultado = _validacoes.MultiplicarNumerosLista(lista, 2);
        _output.WriteLine($"resultado: {resultado}");
        
        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveRetornar9ComoMaiorNumeroDaLista()
    {
        //TODO: Implementar método de teste

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        _output.WriteLine($"lista: {lista}");

        // Act
        var resultado = _validacoes.RetornarMaiorNumeroLista(lista);
        _output.WriteLine($"resultado: {resultado}");

        // Assert
        //TODO: Corrigir o Assert.Equal com base no retorno da chamada ao método
        Assert.Equal(9, resultado);
    }

    [Fact]
    public void DeveRetornarOitoNegativoComoMenorNumeroDaLista()
    {
        //TODO: Implementar método de teste

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        _output.WriteLine($"lista: {lista}");

        // Act
        var resultado = _validacoes.RetornarMenorNumeroLista(lista);
        _output.WriteLine($"resultado: {resultado}");

        // Assert
        //TODO: Corrigir o Assert.Equal com base no retorno da chamada ao método
        Assert.Equal(-8, resultado);
    }
}
