using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTestes
{
    private CalculadoraImp _calc;
    public CalculadoraTestes()
    {
        string data = "02/02/2024";
        _calc = new CalculadoraImp(data);
    }

    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        //Arrange
        int n1 = 5;
        int n2 = 10;

        //Act

        int resultado = _calc.Somar(n1, n2);

        //Assert
        Assert.Equal(15, resultado);
    }
       
        [Fact]
        public void DeveSomar10Com10ERetornar20()
    {
        //Arrange
        int n1 = 10;
        int n2 = 10;

        //Act

        int resultado = _calc.Somar(n1, n2);

        //Assert
        Assert.Equal(20, resultado);
    }

     [Fact]
        public void DeveVerificarSe4EhParERetornarVerdadeiro()
    {
        //Arrange
        int n1 = 4;

        //Act

        bool resultado = _calc.EhPar(n1);

        //Assert
        Assert.True(resultado);
    }

     [Fact]
        public void DeveVerificarSe11EhParERetornarFalso()
    {
        //Arrange
        int n1 = 11;

        //Act

        bool resultado = _calc.EhPar(n1);

        //Assert
        Assert.False(resultado);
    }

    [Theory]
    [InlineData(new int[] { 2 , 4, 6 })]
    [InlineData(new int[] { 10, 12, 22 })]
    public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int[] numero)
    {
        //Act  //Assert
        Assert.All(numero, num=> Assert.True(_calc.EhPar(num)));


    }

    [Theory]
    [InlineData( 1 , 4, 4 )]
    [InlineData( 2, 10, 20)]
    public void TesteMultiplicar(int num1 , int num2, int resultado)
    {
        //Act  //Assert
        int r = _calc.Multiplicar(num1, num2);

        Assert.Equal( resultado, r );


    }

    [Theory]
    [InlineData( 6 , 3, 2 )]
    [InlineData( 20, 5,  4)]
    public void TesteDividir(int num1 , int num2, int resultado)
    {
        //Act  //Assert
        int r = _calc.dividir(num1 , num2);

        Assert.Equal( resultado, r );


    }

    [Theory]
    [InlineData( 6 , 4, 2 )]
    [InlineData( 22, 12,  10)]
    public void TesteSubitrair(int num1 , int num2, int resultado)
    {
        //Act  //Assert
        int r = _calc.Subitrair(num1, num2);

        Assert.Equal( resultado, r );


    }

        [Fact]
        public void testePorZero()
    {
        //Arrange
        int n1 = 11;

        //Act

        bool resultado = _calc.EhPar(n1);

        //Assert
        Assert.Throws<DivideByZeroException>(
            () => _calc.dividir(3,0)
            );
    }

    [Fact]
        public void testeHistorico()
    {
        //Arrange
        _calc.Somar(1,2);
        _calc.Somar(6,42);
        _calc.Somar(8,2);
        _calc.Somar(21,8);

        //Act

        var lista = _calc.historico();

        //Assert
        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }

}