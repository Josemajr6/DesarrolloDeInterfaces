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
            Console.Write("Introduce un número y te diré si es primo: ");
            int numero = int.Parse(Console.ReadLine());

            bool primo = esPrimo(numero);

            if (primo)
            {
                Console.WriteLine("El número " + numero + " es primo");
            }
            else
            {
                Console.WriteLine("El número " + numero + " no es primo");
            }
        }

        public static bool esPrimo(int numero)
        {
            bool esPrimo = true;
            for (int i = 2; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    esPrimo = false;
                }
            }
            return esPrimo;
        }
    }
}
