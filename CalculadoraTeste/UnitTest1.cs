using Calculo;

namespace CalculadoraTeste;

public class UnitTest1
{
    public Calculadora construirClasse()
    {
        string data = "02/11/2025";
        Calculadora calc = new Calculadora(data);

        return calc;
    }

    [Theory]//Usando a teoria
    [InlineData(2, 2, 4)]
    [InlineData(4, 5, 9)]
    public void TesteSomar(int n1, int n2, int resultado)
    {
        Calculadora calc = construirClasse();

        int resultadoSoma = calc.Somar(n1, n2);

        Assert.Equal(resultado, resultadoSoma);
    }

    [Theory]//Usando a teoria
    [InlineData(6, 2, 4)]
    [InlineData(5, 5, 0)]
    public void TesteSubtrair(int n1, int n2, int resultado)
    {
        Calculadora calc = construirClasse();

        int resultadoSoma = calc.Subtrair(n1, n2);

        Assert.Equal(resultado, resultadoSoma);
    }

    [Theory]//Usando a teoria
    [InlineData(2, 2, 4)]
    [InlineData(4, 5, 20)]
    public void TesteMultiplicar(int n1, int n2, int resultado)
    {
        Calculadora calc = construirClasse();

        int resultadoSoma = calc.Multiplicar(n1, n2);

        Assert.Equal(resultado, resultadoSoma);
    }

    [Theory]//Usando a teoria
    [InlineData(8, 2, 4)]
    [InlineData(40, 5, 8)]
    public void TesteDividir(int n1, int n2, int resultado)
    {
        Calculadora calc = construirClasse();

        int resultadoSoma = calc.Dividir(n1, n2);

        Assert.Equal(resultado, resultadoSoma);
    }

    [Fact]
    public void TestarDivisaoPorZero()
    {
        Calculadora calc = construirClasse();

        Assert.Throws<DivideByZeroException>(() => calc.Dividir(3, 0));
    }
    
    [Fact]
    public void TestarHistorico()
    {
        Calculadora calc = construirClasse();

        calc.Somar(1, 2);
        calc.Somar(3, 8);
        calc.Somar(3, 7);
        calc.Somar(4, 1);

        var lista = calc.Historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}
