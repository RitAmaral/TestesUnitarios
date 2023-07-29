namespace Calculadora
{
    public class Calculator
    {
        public int Somar(int numero1, int numero2) => numero1 + numero2;

        public int Subtrair(int numero1, int numero2) => numero1 - numero2;

        public int Dividir(int numero1, int numero2) => numero1 / numero2;

        public int Multiplicar(int numero1, int numero2) => numero1 * numero2;

        //public (int quociente, int resto) RestoDivisao(int numero1, int numero2) => (numero1 / numero2, numero1 % numero2);

        public int RestoDivisao(int numero1, int numero2) => numero1 % numero2;
    }
}