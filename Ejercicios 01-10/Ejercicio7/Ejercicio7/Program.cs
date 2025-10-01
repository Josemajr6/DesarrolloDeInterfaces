using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    internal class Program
    {
        public static bool EsMultiplo(int num1, int num2)
        {

            if (num2 == 0) {
                return false;
            }

            return num1 % num2 == 0;
        }

        static void Main(string[] args)
        {
            Console.Write("Introduce el primer número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Introduce el segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            if (EsMultiplo(numero1, numero2))
            {
                Console.WriteLine(numero1 + " es múltiplo de " + numero2);
            }
            else if (EsMultiplo(numero2, numero1))
            {
                Console.WriteLine(numero2 + " es múltiplo de " + numero1);
            }
            else
            {
                Console.WriteLine("Ninguno de los números es múltiplo del otro");
            }
        }
    }
}


