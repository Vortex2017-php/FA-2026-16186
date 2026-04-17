using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE3_C
{
    internal class ejer3
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese número 1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese número 2: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nSuma: {num1 + num2}");
            Console.WriteLine($"\nResta: {num1 - num2}");
            Console.WriteLine($"\nMultiplicación: {num1 * num2}");
            Console.WriteLine($"\nDivisión: {num1 / num2}");
        }
    }
}
