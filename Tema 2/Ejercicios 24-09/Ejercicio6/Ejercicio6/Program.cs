using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            Console.WriteLine("Número random entre 10 y 30: " + rd.Next(10, 31)); // Para que entre el 30 se debe poner 31
        }
    }
}
