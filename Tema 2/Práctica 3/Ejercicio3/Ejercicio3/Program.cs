using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce un número y calcularé el factorial: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Factorial: " + Factorial(numero));

        }

        public static int Factorial(int numero)
        {
            if (numero == 0 || numero == 1)
            {
                return 1;
            }

            else
            {
                return numero * Factorial(numero - 1);
            }
        }
    }




    }
