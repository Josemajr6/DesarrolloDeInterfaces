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
            Console.Write("Introduce una cadena de texto (de al menos 4 carácteres): ");
            string cadena = Console.ReadLine();

            if (cadena.Length >= 4)
            {
                Console.WriteLine("");
                Console.WriteLine("Longitud de la cadena: " + cadena.Length + " carácteres.");

                if (cadena.Contains("ar"))
                {
                    Console.WriteLine("La cadena contiene [ar]");
                }
                else
                {
                    Console.WriteLine("La cadena no contiene [ar]");
                }

                Console.WriteLine("Cadena cambiando las letras 'a' por letras 'o': " + cadena.Replace("a", "o"));
                Console.WriteLine("Cadena con mayúsculas: " + cadena.ToUpper());
                Console.WriteLine("Cadena con minúsculas: " + cadena.ToLower());

                string cadenaSinTercerCaracter = cadena.Remove(2, 1);
                Console.WriteLine("Cadena sin el tercer carácter: " + cadenaSinTercerCaracter);

                Console.WriteLine("Subcadena con los carácteres 3 y 4: " + cadena.Substring(1, 2));
            }
            else
            {
                Console.WriteLine("La cadena debe tener al menos cuatro carácteres para hacer la prueba");
            }


        }
    }
}
