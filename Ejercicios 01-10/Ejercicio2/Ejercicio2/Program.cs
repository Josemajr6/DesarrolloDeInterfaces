using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce una cadena y te contaré los espacios en blanco: ");
            string cadena = Console.ReadLine();


            Console.WriteLine("Espacios en blanco: " + contarEspacios(cadena));
        }

        public static int contarEspacios(string cadena)
        {
            int contador = 0;

            foreach (char caracter in cadena)
            {
                if (caracter == ' ')
                {
                    contador++;
                }
            }

            return contador;
        }
    }
}
