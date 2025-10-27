using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    internal class Program
    {
        public static int SumarDigitos(int num)
        {
            int suma = 0;

            while (num > 0)
            {
                int digito = num % 10;
                suma += digito;
                num /= 10;
            }

            return suma;
        }

        static void Main(string[] args)
        {
            Console.Write("Introduce un número y sumaré los dígitos: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(SumarDigitos(num));
        }
    }
}