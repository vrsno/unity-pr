using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = Convert.ToInt16("120");
            double doble = 2.5;
            string nombre = "Unity";
            string nombres = "Unity Unreal Godot";
            decimal decimals = 2.07M;
            float flotante = 3.14f;
            bool valor = true;
            char letra = 'A';
            Decimal de = 28.9M;
            Boolean valor2 = false;
            // estructura Bool Decimal Char String Int Double Float
            Console.WriteLine(nombres + " {0} {1} {2} {3}", year, doble, nombre, decimals, valor, letra, de, valor2);
            console.ReadLine();
        }
    }
}