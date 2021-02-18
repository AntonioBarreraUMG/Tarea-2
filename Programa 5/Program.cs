using System;

namespace Programa_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string dia;

            Console.Write("Ingrese un día de la semana: ");
            dia = Console.ReadLine();

            Console.WriteLine("\n");

            switch (dia)
            {
                case "Lunes":
                    Console.WriteLine("Es un día hábil");
                    break;
                case "Martes":
                    Console.WriteLine("Es un día hábil");
                    break;
                case "Miércoles":
                    Console.WriteLine("Es un día hábil");
                    break;
                case "Jueves":
                    Console.WriteLine("Es un día hábil");
                    break;
                case "Viernes":
                    Console.WriteLine("Es un día hábil");
                    break;
                case "Sábado":
                    Console.WriteLine("No es un día hábil");
                    break;
                case "Domingo":
                    Console.WriteLine("No es un día hábil");
                    break;
                default:
                    Console.WriteLine("El día ingresado no es válido");
                    break;
            }
        }
    }
}
