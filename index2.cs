using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // int valor = 3;
            // int valor2 = 4;
            // var suma = valor + valor2;
            // var resta = valor - valor2;
            // var multiplicacion = valor * valor2;
            // var division = valor / valor2;

            int valor1 = 34;
            int valor2 = 4;
            //valor1 += valor2; // Suma
            //valor1 -= valor2; // resta
            //valor1 *= valor2; // Multiplicación
            //valor1 /= valor2; // División
            valor1 %= valor2; // Módulo-residuo
            Console.WriteLine("Valor1 después de asignacion: " + valor1);
            Console.ReadLine();
        }
    }
}