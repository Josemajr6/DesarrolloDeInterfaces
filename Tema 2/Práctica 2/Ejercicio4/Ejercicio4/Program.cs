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
            Console.Write("Introduce un número y calcularé el factorial: ");
            int num = int.Parse(Console.ReadLine());
            int factorial = 1;
            if (num == 0) {
                factorial = 1;
            }
            else
            {
                for (int i = 1; i <= num; i++) {
                    factorial *= i;
                }
            }
            Console.WriteLine("Factorial de " + num + ": " + factorial);
   


        }
    }
}
