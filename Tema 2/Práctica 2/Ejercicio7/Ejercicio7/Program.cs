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
            Console.Write("Indica el tamaño del array: ");
            int cantidad = int.Parse(Console.ReadLine());

            int[] numeros = new int[cantidad];

            for (int i = 0; i <= cantidad - 1; i++)
            {
                Console.Write("Indica el valor " + (i+1) + " del array: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("");
            for (int i = 0; i <= cantidad -1; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    Console.WriteLine(numeros[i] + " es par");
                }
                else
                {
                    Console.WriteLine(numeros[i] + " es impar");
                }
            }

        }
    }
}
