using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Cliente
    {
        private String nombre;
        private double cantidadTotal;

        public Cliente (string nombre)
        {
            this.nombre = nombre;
            this.cantidadTotal = 0;
        }

        public void Ingresar(double cantidad)
        {
            if (cantidad > 0)
            {
                cantidadTotal += cantidad;
            }
            else
            {
                Console.WriteLine("Error: Debes ingresar un valor mayor a 0");
            }
        }

        public void Sacar(double cantidad)
        {
            if (cantidadTotal >= 0)
            {
                cantidadTotal -= cantidad;
            }
            else
            {
                Console.WriteLine("Fondos insuficientes");
            }
        }

        public double GetCantidadTotal()
        {
            return cantidadTotal;
        }

        public void mostrarInformacion()
        {
            Console.WriteLine("Total: " + this.GetCantidadTotal());
        }
    }

    class Banco
    {
        protected Cliente cliente1;
        protected Cliente cliente2;
        protected Cliente cliente3;

        public Banco()
        {
            cliente1 = new Cliente("Juanjo");
            cliente2 = new Cliente("Ana");
            cliente3 = new Cliente("David");

        }

        public void Operar()
        {
            cliente1.Ingresar(2500);
            cliente2.Ingresar(3500);
            cliente3.Ingresar(50);
        }

        public void ObtenerEstado()
        {
            Console.WriteLine("Dinero total ingresado: " + (cliente1.GetCantidadTotal() + cliente2.GetCantidadTotal() + cliente3.GetCantidadTotal()));
            Console.WriteLine("Cliente 1 Total: " + cliente1.GetCantidadTotal());
            Console.WriteLine("Cliente 2 Total: " + cliente2.GetCantidadTotal());
            Console.WriteLine("Cliente 3 Total: " + cliente3.GetCantidadTotal());
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Banco banco = new Banco();
            banco.Operar();
            banco.ObtenerEstado();

        }
    }
}
