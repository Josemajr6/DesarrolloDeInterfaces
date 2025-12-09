using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2___3
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        public string Email { get; set; }

        public string Direccion { get; set; }

        public Usuario(int id, string nombre, string apellidos, string email, string direccion)
        {
            Id = id;
            Nombre = nombre;
            Apellidos = apellidos;
            Email = email;
            Direccion = direccion;
        }
    }
}
