using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    public class Empleado
    {
   
        public string nombre;
        public int numHorasExtra;
        public double salarioSinExtras;

  
        public Empleado(string nombre, double salario)
        {
            this.nombre = nombre;
            this.salarioSinExtras = salario;
            this.numHorasExtra = 0;
        }

        public void HaceHoraExtra(int horas)
        {
            numHorasExtra += horas;
        }

     
        public double CalculaSalarioTotal()
        {
            return salarioSinExtras + (25 * numHorasExtra);
        }
     
    }
}