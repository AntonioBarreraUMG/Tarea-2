using System;

namespace Programa_1
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra;

            Console.Write("Ingrese una letra: ");
            letra = Convert.ToChar(Console.Read());

            if (char.IsUpper(letra))
                Console.WriteLine("\nLa letra ingresada es mayúscula.");
            else
                Console.WriteLine("\nLa letra ingresada es minúscula.");
        }
    }
}
