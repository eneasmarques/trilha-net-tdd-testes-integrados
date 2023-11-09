
using NewTalents;

namespace NewTalents.Tests;

public class CalculadoraTests
{
    private readonly Calculadora _calculadora;

    public CalculadoraTests()
    {
        string data = "08/11/2023";
        _calculadora = new Calculadora(data);
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5, 9)]
    public void DeveSomarDoisNumeros(int val1, int val2, int resultado)
    {
        int resultadoCalculadora = _calculadora.Somar(val1, val2);
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(2, 1, 1)]
    [InlineData(5, 3, 2)]
    public void DeveSubtrairDoisNumeros(int val1, int val2, int resultado)
    {
        int resultadoCalculadora = _calculadora.Subtrair(val1, val2);
        Assert.Equal(resultado, resultadoCalculadora);
    }
    
    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(4, 5, 20)]
    public void DeveMultiplicarDoisNumeros(int val1, int val2, int resultado)
    {
        int resultadoCalculadora = _calculadora.Multiplicar(val1, val2);
        Assert.Equal(resultado, resultadoCalculadora);
    }
    
    [Theory]
    [InlineData(6, 2, 3)]
    [InlineData(10, 5, 2)]
    public void DeveDividirDoisNumeros(int val1, int val2, int resultado)
    {
        int resultadoCalculadora = _calculadora.Dividir(val1, val2);
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Fact]
    public void TestarDivisaoPorZero()
    {
        Assert.Throws<DivideByZeroException>(
            () => _calculadora.Dividir(3, 0)
        );
    }

    [Fact]
    public void DeveTerUmHistorico()
    {
        _calculadora.Somar(1, 2);
        _calculadora.Subtrair(2, 1);
        _calculadora.Multiplicar(2, 5);

        var lista = _calculadora.Historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}