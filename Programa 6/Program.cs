using System;

namespace Programa_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, cont = 0;
            Console.Write("Ingrese un número: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < (num + 1); i++)
            {
                if (num % i == 0)
                {
                    cont++;
                }
            }
            if (cont != 2)
            {
                Console.WriteLine("\nEl número ingresado NO es un número primo.");
            }
            else
            {
                Console.WriteLine("\nEl número ingresado es un número primo.");
            }
        }
    }
}
