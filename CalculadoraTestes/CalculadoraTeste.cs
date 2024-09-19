using CalculadoraConsole.Services;

namespace CalculadoraTestes
{
    public class CalculadoraTeste
    {
        public Calculadora construirCalculadora()
        {
            string data = DateTime.Now.ToShortDateString();

            Calculadora calc = new Calculadora(data);

            return calc;
        }

        [Fact]
        public void Somar_5Com10_ERetornar15()
        {
            Calculadora calc = construirCalculadora();

            int num1 = 5;
            int num2 = 10;

            int resultado = calc.Somar(num1, num2);

            Assert.Equal(15, resultado);
        }

        [Fact]
        public void Somar_20Com30_ERetornar50()
        {
            Calculadora calc = construirCalculadora();

            int num1 = 20;
            int num2 = 30;

            int resultado = calc.Somar(num1, num2);

            Assert.Equal(50, resultado);
        }

        [Theory]
        [InlineData(5, 10, 15)]
        [InlineData(20, 30, 50)]
        public void Somar_Valor1EValor2_RetornarValor3(int num1, int num2, int esperado)
        {
            Calculadora calc = construirCalculadora();

            int resultado = calc.Somar(num1, num2);

            Assert.Equal(esperado, resultado);
        }

        [Theory]
        [InlineData(10, 6, 4)]
        [InlineData(20, 30, -10)]
        public void Subtrair_Valor1EValor2_RetornarValor3(int num1, int num2, int esperado)
        {
            Calculadora calc = construirCalculadora();

            int resultado = calc.Subtrair(num1, num2);

            Assert.Equal(esperado, resultado);
        }

        [Theory]
        [InlineData(10, 6, 60)]
        [InlineData(20, 50, 1000)]
        public void Multiplicar_Valor1EValor2_RetornarValor3(int num1, int num2, int esperado)
        {
            Calculadora calc = construirCalculadora();

            int resultado = calc.Multiplicar(num1, num2);

            Assert.Equal(esperado, resultado);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(75, 25, 3)]
        public void Dividir_Valor1EValor2_RetornarValor3(int num1, int num2, int esperado)
        {
            Calculadora calc = construirCalculadora();

            int resultado = calc.Dividir(num1, num2);

            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void DividirPorZeroTeste()
        {
            Calculadora calc = construirCalculadora();

            Assert.Throws<DivideByZeroException>(() => calc.Dividir(3, 0));
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = construirCalculadora();

            calc.Somar(1,2);
            calc.Somar(2,3);
            calc.Somar(3,4);
            calc.Somar(4,5);

            List<string> lista = calc.Historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}