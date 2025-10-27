using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce el precio de un artículo: ");
            double precio = double.Parse(Console.ReadLine());

            Console.Write("Introduce la cantidad: ");
            int cantidad = int.Parse(Console.ReadLine());

            Console.Write("Coste total: " + (precio * cantidad));
        }
    }
}
