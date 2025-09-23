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
            Console.Write("Introduce el primer valor númerico: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Introduce el segundo valor númerico: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Introduce el tercer valor númerico: ");
            double num3 = double.Parse(Console.ReadLine());

            Console.Write("Introduce el cuarto valor númerico: ");
            double num4 = double.Parse(Console.ReadLine());

            Console.WriteLine("");
            double sumaValores = (num1+num2+num3+num4);
            double promedioValores = sumaValores / 4;
            Console.WriteLine("Suma de los cuatro valores numéricos: " + sumaValores);
            Console.WriteLine("Promedio de los cuatro valores nunéricos" + promedioValores);



        }
    }
}
