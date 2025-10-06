using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Juego juego1 = new Juego(5);
            juego1.MuestraVidasRestantes();

            juego1.vidas--;

            juego1.MuestraVidasRestantes();

            Juego juego2 = new Juego(5);
            juego2.MuestraVidasRestantes();

            juego1.MuestraVidasRestantes();
        }
    }
}
