using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace SE3_C
{
    internal class eje5
    {
        static void Main(String[] args)
        {
            Console.Write("Ingrese un numero: ");
            string num = Console.ReadLine();
            int entero = int.Parse(num); ;
            double deci = double.Parse(num);

            Console.WriteLine($"\nRestos: {entero % 2}");
            Console.WriteLine($"Dividido entre 3: {deci / 3}");
        }
    }
}
