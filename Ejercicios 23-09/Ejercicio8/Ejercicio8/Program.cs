using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce la primera nota de tu examen: ");
            double examen1 = double.Parse(Console.ReadLine());

            Console.Write("Introduce la segunda nota de tu examen: ");
            double examen2 = double.Parse(Console.ReadLine());

            Console.Write("Introduce tu nota de los trabajos de clase: ");
            double trabajosClase = double.Parse(Console.ReadLine());

            Console.Write("Introduce tu nota en la actitud: ");
            double actitud = double.Parse(Console.ReadLine());

            double notaFinal = (((examen1 + examen2) / 2) * 0.5) + (trabajosClase * 0.3) + (actitud * 0.2);

            Console.WriteLine("");
            Console.WriteLine("Nota final: " + notaFinal);
        }
    }
}
