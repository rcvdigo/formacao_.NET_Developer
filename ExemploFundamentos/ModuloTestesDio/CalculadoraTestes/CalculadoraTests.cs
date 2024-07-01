using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTests
{
    private CalculadoraImp _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        // Temos três conceitos de testes
        
        // Arrange (Determina o que devemos passar em nosso método)
        int num1 = 5;
        int num2 = 10;

        // Act (Determina a ação)
        int resultado = _calc.Somar(num1, num2);

        // Assert (Determina o Retorno esperado)
        Assert.Equal(15, resultado);
    }

    [Fact]
    public void DeveSomar10Com10ERetornar20()
    {
        // Temos três conceitos de testes
        
        // Arrange (Determina o que devemos passar em nosso método)
        int num1 = 10;
        int num2 = 10;

        // Act (Determina a ação)
        int resultado = _calc.Somar(num1, num2);

        // Assert (Determina o Retorno esperado)
        Assert.Equal(20, resultado);
    }

    [Fact]
    public void DeveVerificarSe4EhParERetornarVerdadeiro()
    {
        // Arrange (Determina o que devemos passar em nosso método)
        int numero = 4;
        // Act (Determina a ação)
        bool resultado = _calc.IsPar(numero);
        // Assert (Determina o Retorno esperado)
        Assert.True(resultado);
    }

    [Theory]
    [InlineData(new int[] { 2, 4})]
    [InlineData(new int[] { 6, 8, 10})]
    public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int[] numeros)
    {
        // Arrange (Determina o que devemos passar em nosso método)

        // Act (Determina a ação)
        Assert.All(numeros, num => Assert.True(_calc.IsPar(num)));
        // Assert (Determina o Retorno esperado)
    }
}