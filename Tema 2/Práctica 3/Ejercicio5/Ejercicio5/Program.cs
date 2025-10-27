using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        static double PotenciaIterativa(int baseNum, int exponente)
        {
            double resultado = 1;
            for (int i = 0; i < exponente; i++)
            {
                resultado *= baseNum;
            }
            return resultado;
        }

        static double PotenciaRecursiva(int baseNum, int exponente)
        {
            if (exponente == 0)
            {
                return 1;
            }
            else
            {
                return baseNum * PotenciaRecursiva(baseNum, exponente - 1);
            }
               
        }

        static void Main(string[] args)
        {
            Console.Write("Introduce la base: ");
            int baseNum = int.Parse(Console.ReadLine());

            Console.Write("Introduce el exponente: ");
            int exponente = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Forma iterativa: " + baseNum + "^" + exponente + " = " + PotenciaIterativa(baseNum, exponente));
            Console.WriteLine("Forma recursiva: " + baseNum + "^" + exponente + " = " + PotenciaRecursiva(baseNum, exponente));


        }
    }
}

