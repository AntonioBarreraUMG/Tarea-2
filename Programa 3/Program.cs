using System;

namespace Programa_3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int precioNorm = 16;
            const int precioExt = 20;
            int cantHor, cantNorm, cantExt;

            Console.WriteLine("\t***CALCULADORA DE SALARIO***");

            Console.Write("\n  Ingrese la cantidad de horas trabajadas: ");
            cantHor = Convert.ToInt32(Console.ReadLine());

            if (cantHor > 40 && cantHor < 85)
            {
                cantExt = cantHor - 40;
                cantNorm = cantHor - cantExt;

                Console.WriteLine("\n---Cantidad por tipo de horario---");
                Console.WriteLine("Normales: " + cantNorm);
                Console.WriteLine("Extras: " + cantExt);
                Console.WriteLine("\n---Precio total por horario---");
                Console.WriteLine("Normales: " + (cantNorm * precioNorm));
                Console.WriteLine("Extras: " + (cantExt * precioExt));
                Console.WriteLine("\nSALARIO SEMANAL: " + ((cantNorm * precioNorm) + (cantExt * precioExt)));
            }
            else if (cantHor > 0 && cantHor < 41)
            {
                Console.WriteLine("\nSALARIO SEMANAL: " + (cantHor * precioNorm));
            }
            else
            {
                Console.Write("\n¡¡¡La cantidad ingresada no es válida!!!");
            }
        }
    }
}
