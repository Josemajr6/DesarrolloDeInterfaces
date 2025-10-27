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
            const double precioHamburguesa = 5.50;
            const double precioPatatas = 3;
            const double precioBebida = 2.25;

            Console.Write("Introduce la cantidad de hamburguesas consumidas: ");
            int cHambuguesas = int.Parse(Console.ReadLine());



            Console.Write("Introduce la cantidad de patatas consumidas: ");
            int cPatatas = int.Parse(Console.ReadLine());
   

            Console.Write("Introduce la cantidad de bebidas consumidas: ");
            int cBebidas = int.Parse(Console.ReadLine());
        


            Console.WriteLine(" ");
            double total = (cHambuguesas * precioHamburguesa) + (cPatatas * precioPatatas) + (cBebidas * precioBebida);

            if (cHambuguesas <0 || cPatatas <0 || cBebidas < 0)
            {
                Console.WriteLine("Error. Has introducido algún número negativo");
            }
            else
            {
                Console.WriteLine("Total a pagar: " + total + " euros");
            }
                

        }
    }
}
