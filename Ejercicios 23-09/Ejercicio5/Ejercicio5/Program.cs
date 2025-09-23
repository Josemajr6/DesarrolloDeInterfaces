using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce el primer número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Introduce el segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Introduce el tercer número: ");
            double num3 = double.Parse(Console.ReadLine());

            Console.Write("Introduce el cuarto número: ");
            double num4 = double.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Suma de los dos primeros números: " + (num1+num2));
            Console.WriteLine("Producto del tercero y el cuarto: " + (num3*num4));

        }
    }
}
