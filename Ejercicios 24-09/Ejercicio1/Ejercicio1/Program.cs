using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indica su estado civil (C - Casado, S - Soltero, V - Viudo, D - Divorciado): ");
            char respuesta = char.Parse(Console.ReadLine());
    

            switch (respuesta)
            {
                case 'C':
                    Console.WriteLine("Tu estado civil es casado");
                    break;
                case 'S':
                    Console.WriteLine("Tu estado civil es soltero");
                    break;
                case 'V':
                    Console.WriteLine("Tu estado civil es viudo");
                    break;
                case 'D':
                    Console.WriteLine("Tu estado civil es divorciado");
                    break;
                default:
                    Console.WriteLine("Opción inválida");
                    break;
            } 
        }
    }
}
