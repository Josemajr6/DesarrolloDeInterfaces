using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{

    class Cuenta
    {
        private string titular;
        private double cantidad;

        public Cuenta (string titular)
        {
            this.titular = titular;
            this.cantidad = 0.0;
        }

        public Cuenta(string titular, double cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string getTitular()
        {
            return this.titular;
        }

        public double getCantidad()
        {
            return this.cantidad;
        }

        public void setTitular(string titularS)
        {
            this.titular = titularS;
        }

        public void setCantidad(double cantidadS)
        {
            this.cantidad = cantidadS;
        }

        public string toString()
        {
            return "Titular: " + titular + ", cantidad: " + cantidad;
        }

        public void Ingresar(double cantidadI)
        {
            if (cantidadI > 0)
            {
                this.cantidad += cantidadI;
            }
            else
            {
                Console.WriteLine("Error. Introduce un número válido para ingresar");
            }
        }

        public void Retirar(double cantidadI)
        {
            if (cantidad >= cantidadI)
            {
                this.cantidad -= cantidadI;
            }
            else
            {
                Console.WriteLine("Error. Fondos insuficientes");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta01 = new Cuenta("pepe");
            cuenta01.Ingresar(300);
            cuenta01.Retirar(100);

            Console.WriteLine(cuenta01.toString());
            
        }
    }
}
