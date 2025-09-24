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
            int[] numeros = {3, 9, 1, 5, 6, 2, 4, 7, 10, 8};

            Console.WriteLine("Array desordenado: ");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write(numeros[i] + " ");
            }

            Console.WriteLine("");


            Console.WriteLine("Array ordenado: ");

            Array.Sort(numeros);

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write(numeros[i] + " ");
            }



        }
    }
}
