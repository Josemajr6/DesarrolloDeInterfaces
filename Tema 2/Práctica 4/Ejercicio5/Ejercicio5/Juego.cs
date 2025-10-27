using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Juego
    {
        public int vidas;

        public Juego(int vidasIniciales)
        {
            vidas = vidasIniciales;
        }

        public void MuestraVidasRestantes()
        {
            Console.WriteLine("Vidas restantes: " + vidas);
        }

    }
}
