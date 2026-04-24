using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE4_C
{
    internal class ejer3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------SISTEMA DE CONVERSIÓN MONETARIO--------");
            Console.Write("Ingrese el monto en soles: ");
            double moneda = double.Parse(Console.ReadLine());

            Console.WriteLine("\n1. Convertir a dolares");
            Console.WriteLine("2. Convertir a a euros\n");


            Console.WriteLine("Ingrese una opción");
            int opciones = int.Parse(Console.ReadLine());

            switch (opciones)
            {
                case 1:
                    double dolares = moneda / 3.75;
                    Console.WriteLine("\nDolares: " + dolares);
                    break;
                case 2:
                    double euros = moneda / 4.05;
                    Console.WriteLine("\nEuros: " + euros);
                    break;
                default:
                    Console.WriteLine("Opción incorrecta");
                    break;
            }


        }
    }
}
