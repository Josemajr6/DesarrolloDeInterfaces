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
            Console.Write("Introduce un número del 1 al 9: ");
            int num = int.Parse(Console.ReadLine());

            if (num > 0 && num < 10)
            {
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine(num + "x" + i + "=" + num*i);
                }
            }
            else
            {
                Console.WriteLine("Debes intruducir un número entre el 1 y el 9");
            }
        }
    }
}
