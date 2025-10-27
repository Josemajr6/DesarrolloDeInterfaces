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

            CD cd1 = new CD();

            Cancion c1 = new Cancion("Gasolina", "Daddy Yankee");
            Cancion c2 = new Cancion("Cobro", "De la Rose");
            Cancion c3 = new Cancion("Tití Me Preguntó", "Tití Me Preguntó");

            cd1.agrega(c1);
            cd1.agrega(c2);
            cd1.agrega(c3);

            Console.WriteLine("Número de canciones: " + cd1.numeroCanciones());
            Console.WriteLine();

            for (int i = 0; i < cd1.numeroCanciones(); i++)
            {
                Cancion c = cd1.dameCancion(i);
                Console.WriteLine((i + 1) + ". " + c.dameTitulo() + " - " + c.dameAutor());
            }

            Console.WriteLine();

            // Voy a borrar por ejemplo de la Bad Bunny y hacer otra vez el listado
            cd1.elimina(2);

            Console.WriteLine("Lista de canciones:");
            for (int i = 0; i < cd1.numeroCanciones(); i++)
            {
                Cancion c = cd1.dameCancion(i);
                Console.WriteLine((i + 1) + ". " + c.dameTitulo() + " - " + c.dameAutor());
            }
        }
    }
}
