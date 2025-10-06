using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class CD
    {
        private ArrayList canciones;

        public CD()
        {
            canciones = new ArrayList();
        }

        public int numeroCanciones()
        {
            return canciones.Count;
        }

        public Cancion dameCancion(int posicion)
        {
            if (posicion >= 0 && posicion < canciones.Count)
                return (Cancion)canciones[posicion];
            return null;
        }

        public void grabaCancion(int posicion, Cancion nueva)
        {
            if (posicion >= 0 && posicion < canciones.Count)
                canciones[posicion] = nueva;
        }

        public void agrega(Cancion nueva)
        {
            canciones.Add(nueva);
        }

        public void elimina(int posicion)
        {
            if (posicion >= 0 && posicion < canciones.Count)
                canciones.RemoveAt(posicion);
        }
    }
}
