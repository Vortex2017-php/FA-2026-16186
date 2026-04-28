using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE4_C
{
    internal class ejer4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------SISTEMA DE CALCULO DE ÁREA--------\n");

            Console.WriteLine("1. Área del Cuadrado");
            Console.WriteLine("2. Área del Triángulo");
            Console.WriteLine("3. Área del Rectángulo");
            Console.WriteLine("4. Área del Círculo");


            Console.WriteLine("Ingrese una opción");
            int opciones = int.Parse(Console.ReadLine());

            switch (opciones)
            {
                case 1:
                    Console.WriteLine("\nIngrese el lado del cuadrado: ");
                    int lado = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nÁrea del Cuadrado: " + (lado * lado));
                    break;
                case 2:
                    Console.WriteLine("\nIngresa la base del triángulo: ");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa la altura del triángulo: ");
                    int h = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nÁrea del Triángulo: " + (b * h) / 2);
                    break;
                case 3:
                    Console.WriteLine("\nIngrese la base del rectángulo: ");
                    int b1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura del rectángulo: ");
                    int h1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nÁrea del Rectángulo: " + (b1 * h1));
                    break;
                case 4:
                    Console.WriteLine("\nIngrese el radio círculo: ");
                    int r = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nÁrea del Círculo:" + (Math.PI*Math.Pow(r , 2))); 
                    break;
                default:
                    Console.WriteLine("Opción incorrecta");
                    break;
            }


        }
    }
}