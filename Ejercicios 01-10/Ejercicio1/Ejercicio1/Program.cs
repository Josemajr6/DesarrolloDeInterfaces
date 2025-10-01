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
            Console.Write("Introduce el tamaño del array de enteros: ");
            int tamano = int.Parse(Console.ReadLine());

            int[] numeros = new int[tamano];
            int suma = 0;

            for (int i = 0; i < tamano; i++)
            {
                Console.Write("Introduce el valor " + (i + 1) + " del array: "); // Podría poner en vez de i + 1 que empiece por 1 la i y llegue a tamano - 1
                numeros[i] = int.Parse(Console.ReadLine());
                suma += numeros[i];
            }

            Console.WriteLine("La suma de los números es: " + suma);
            Console.WriteLine("Media de todos los valores del array: " + (suma / numeros.Length)); // También se podría dividir entre la variable tamano
         
        }
    }

}
