using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = {5, 3, 2, -7, 8, 1};

            int menor = numeros[0];
            int pos = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                    pos = i;
                }
            }

            Console.WriteLine("Posición del número menor (contando el 0): " + pos + ". El número menor es " + menor);
        }

       
    }
}
