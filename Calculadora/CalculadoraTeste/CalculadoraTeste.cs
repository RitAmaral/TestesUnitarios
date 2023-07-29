using Calculadora;

namespace CalculadoraTeste
{
    public class CalculadoraTeste
    {
        /*------------------------------Somar-------------------------- */

        [Fact]
        public void Somar_DevolverValorCorreto()
        {
            Calculator c = new Calculator();
            var resultado = c.Somar(5, 10);

            Assert.Equal(15, resultado);
        }

        [Theory]
        [InlineData(3, 3, 6)]
        [InlineData(2, 5, 7)]
        public void Somar_DevolverValorCorreto1(int numero1, int numero2, int expected)
        {
            Calculator c = new Calculator();
            var resultado = c.Somar(numero1, numero2);

            Assert.Equal(expected, resultado);
        }

        /*------------------------------Subtrair-------------------------- */

        [Fact]
        public void Subtrair_DevolverValorCorreto()
        {
            Calculator c = new Calculator();
            var resultado = c.Subtrair(10, 5);

            Assert.Equal(5, resultado);
        }

        [Theory] //usamos se quisermos testar mas coisas
        [InlineData(3, 2, 1)]
        [InlineData(10,15,-5)]
        public void Subtrair_DevolverValorCorreto1(int numero1, int numero2, int expected)
        {
            Calculator c = new Calculator();
            var resultado = c.Subtrair(numero1, numero2);

            Assert.Equal(expected, resultado); //expected é uma variável normal, posso mudar o nome
        }

        /*------------------------------Dividir-------------------------- */

        [Fact]
        public void Dividir_DevolverValorCorreto()
        {
            Calculator c = new Calculator();
            var resultado = c.Dividir(8, 2);
            Assert.Equal(4, resultado);
        }

        [Theory]
        [InlineData(8, 2, 4)]
        [InlineData(10, 2, 5)]
        public void Dividir_DevolverValorCorreto1(int numero1, int numero2, int expected)
        {
            Calculator c = new Calculator();
            var resultado = c.Dividir(numero1, numero2);

            Assert.Equal(expected, resultado);
        }

        /*------------------------------Multiplicar-------------------------- */

        [Fact]
        public void Multiplicar_DevolverValorCorreto()
        {
            Calculator c = new Calculator();
            var resultado = c.Multiplicar(2, 2);

            Assert.Equal(4, resultado);
        }

        [Theory]
        [InlineData(3, 2, 6)]
        [InlineData(2, 4, 8)]
        public void Multiplicar_DevolverValorCorreto1(int numero1, int numero2, int expected)
        {
            Calculator c = new Calculator();
            var resultado = c.Multiplicar(numero1, numero2);

            Assert.Equal(expected, resultado);
        }

        /*------------------------------Resto da Divisão-------------------------- */

        [Fact]
        public void Resto_DevolverValorCorreto()
        {
            Calculator c = new Calculator();
            var resultado = c.RestoDivisao(12, 2);

            Assert.Equal(0, resultado);
        }

        [Theory]
        [InlineData(12, 2, 0)]
        [InlineData(12, 4, 0)]
        public void Resto_DevolverValorCorreto1(int numero1, int numero2, int expected)
        {
            Calculator c = new Calculator();
            var resultado = c.RestoDivisao(numero1, numero2);

            Assert.Equal(expected, resultado);
        }
    }
}