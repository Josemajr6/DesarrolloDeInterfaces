using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Introduce el valor de un lado del cuadrado: ");
            double valorLado = double.Parse(Console.ReadLine());

           Console.WriteLine("Perímetro del cuadrado: " + (valorLado * 4));

        }
    }
}
