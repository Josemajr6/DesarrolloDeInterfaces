using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cancion c1 = new Cancion("La noche de anoche", "Bad Bunny");
            Console.WriteLine("Canción 1:");
            Console.WriteLine("Título: " + c1.dameTitulo());
            Console.WriteLine("Autor: " + c1.dameAutor());
            Console.WriteLine();

            Cancion c2 = new Cancion();
            c2.ponTitulo("Escalofríos");
            c2.ponAutor("Mora");

            Console.WriteLine("Canción 2:");
            Console.WriteLine("Título: " + c2.dameTitulo());
            Console.WriteLine("Autor: " + c2.dameAutor());

        }
    }
}
