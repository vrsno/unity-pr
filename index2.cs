using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = 3;
            int valor2 = 4;
            var suma = valor + valor2;
            var resta = valor - valor2;
            var multiplicacion = valor * valor2;
            var division = valor / valor2;
            Console.WriteLine(suma, " {0} {1} {2} {3}", resta, multiplicacion, division);
            Console.ReadLine();
        }
    }
}