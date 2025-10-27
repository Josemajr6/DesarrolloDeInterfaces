using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce un número: ");
            double num = double.Parse(Console.ReadLine());

            double numExtra = 5;

            Console.WriteLine("");
            Console.WriteLine("Valor absoluto: " + Math.Abs(num));
            Console.WriteLine("Potencia al cubo: " + (num * num * num));
            Console.WriteLine("Raíz cuadrada: " + Math.Sqrt(num));
            Console.WriteLine("Seno: " + Math.Sin(num));
            Console.WriteLine("Coseno: " + Math.Cos(num));
            Console.WriteLine("Número maximo (usando " + numExtra + " como número extra): " + Math.Max(num, numExtra));
            Console.WriteLine("Número mínimo (usando " + numExtra + " como número extra): " + Math.Min(num, numExtra));



        }
    }
}
