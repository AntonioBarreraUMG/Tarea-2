using System;

namespace Programa_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int compra;

            Console.WriteLine("\t***Megaplaza***");
            Console.WriteLine("   Calculadora de descuentos\n");

            Console.Write("Ingrese el monto total de la compra: ");
            compra = Convert.ToInt32((Console.ReadLine()));

            if (compra > 300)
            {
                Console.WriteLine("\nEl total a pagar es: " + (compra - (compra * 0.2)));
            }
            else
            {
                Console.WriteLine("\nEl total a pagar es: " + compra);
            }



        }
    }
}
