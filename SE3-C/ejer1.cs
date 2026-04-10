using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE3_C
{
    internal class ejer1
    {
        static void Main(string[] args)
        {
            String N, C;
            Console.Write("\nIngrese nombre: ");
            N = Console.ReadLine(); 
            Console.Write("\nIngrese carrera: ");
            C = Console.ReadLine();

            Console.WriteLine("\n-------------- IMPRESIÓN CON + --------------");
            Console.WriteLine(N+", Bienvenido al curso de Fundamentos de Algoritmo " + C);

            Console.WriteLine("\n-------------- IMPRESIÓN CON $ --------------");
            Console.WriteLine($"{N}, Bienvenido al curso de Fundamentos de Algoritmo {C}");

            Console.ReadKey();
        }
    }
}
