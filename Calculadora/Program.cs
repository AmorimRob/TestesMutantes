using System;

namespace Calculadora
{
    class Program
    {
        private static ICalculadora calculadora = new Calculadora();

        static void Main(string[] args)
        {
            Console.WriteLine("Informe seu salário: ");
        }
    }
}
