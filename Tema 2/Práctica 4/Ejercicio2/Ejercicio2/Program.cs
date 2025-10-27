using System;

namespace Ejercicio2
{
    class Contacto
    {
        private string nombre;
        private string telefono;

        public Contacto(string nombre, string telefono)
        {
            this.nombre = nombre;
            this.telefono = telefono;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public string getTelefono()
        {
            return this.telefono;
        }

        public void setNombre(string nombreS)
        {
            this.nombre = nombreS;
        }

        public void setTelefono(string telefonoS)
        {
            this.telefono = telefonoS;
        }
    }

    class Agenda
    {
        private Contacto[] contactos;
        private int pos;

        public Agenda()
        {
            this.contactos = new Contacto[10];
            this.pos = 0;
        }

        public Agenda(int tamano)
        {
            this.contactos = new Contacto[tamano];
            this.pos = 0;
        }

        public void anadirContacto(Contacto c)
        {
            if (pos >= contactos.Length)
            {
                Console.WriteLine("No se pueden añadir más contactos. La agenda está llena.");
                return;
            }

            for (int i = 0; i < pos; i++)
            {
                if (contactos[i] != null && contactos[i].getNombre().Equals(c.getNombre()))
                {
                    Console.WriteLine("Ya existe un contacto con ese nombre.");
                    return;
                }
            }

            contactos[pos] = c;
            pos++;
            Console.WriteLine("Contacto " + c.getNombre() + " añadido correctamente");
        }

        public bool existeContacto(Contacto c)
        {
            for (int i = 0; i < pos; i++)
            {
                if (contactos[i] != null && contactos[i].getNombre().Equals(c.getNombre()))
                {
                    return true;
                }
            }
            return false;
        }

        public void listarContactos()
        {
            Console.WriteLine("Agenda:");
            for (int i = 0; i < pos; i++)
            {
                if (contactos[i] != null)
                {
                    Console.WriteLine(contactos[i].getNombre() + " : " + contactos[i].getTelefono());
                }
            }
        }

        public void buscarContactos(string nombre)
        {
            for (int i = 0; i < pos; i++)
            {
                if (contactos[i] != null && contactos[i].getNombre().Equals(nombre))
                {
                    Console.WriteLine("Teléfono: " + contactos[i].getTelefono());
                    return;
                }
            }
            Console.WriteLine("No se ha encontrado ningún contacto con ese nombre.");
        }

        public void eliminarContacto(Contacto c)
        {
            bool eliminado = false;
            Contacto[] nuevos = new Contacto[contactos.Length];
            int nuevaPos = 0;

            for (int i = 0; i < pos; i++)
            {
                if (contactos[i] != null && !contactos[i].getNombre().Equals(c.getNombre()))
                {
                    nuevos[nuevaPos] = contactos[i];
                    nuevaPos++;
                }
                else if (contactos[i] != null && contactos[i].getNombre().Equals(c.getNombre()))
                {
                    eliminado = true;
                }
            }

            if (eliminado)
            {
                contactos = nuevos;
                pos = nuevaPos;
                Console.WriteLine("Contacto " + c.getNombre() + " eliminado correctamente");
            }
            else
            {
                Console.WriteLine("No se ha eliminado el contacto. Puede que no existiera en la agenda.");
            }
        }

        public bool agendaLlena()
        {
            return pos >= contactos.Length;
        }

        public void huecosLibres()
        {
            if (pos < contactos.Length)
            {
                Console.WriteLine("Te quedan " + (contactos.Length - pos) + " huecos libres.");
            }
            else
            {
                Console.WriteLine("No te quedan huecos libres.");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Agrego los 5 contactos
            Contacto c01 = new Contacto("José", "+34 722625288");
            Contacto c02 = new Contacto("Pepa", "+34 612625288");
            Contacto c03 = new Contacto("Gabriela", "+34 605625286");
            Contacto c04 = new Contacto("Martín", "+34 698432987");
            Contacto c05 = new Contacto("Lucía", "+34 688742134");

            // Creo la agenda para almacenar justo 5 contactos
            Agenda agenda = new Agenda(5);


            agenda.anadirContacto(c01);
            agenda.anadirContacto(c02);
            agenda.anadirContacto(c03);
            agenda.anadirContacto(c04);
            agenda.anadirContacto(c05);

            // Dejo separación antes de listarlos, elimino uno y los vuelto a listar
            Console.WriteLine();
            agenda.listarContactos();

            Console.WriteLine();
            agenda.eliminarContacto(c03);
            Console.WriteLine();

            agenda.listarContactos();

            // Como he borrado uno me dice que me queda 1 hueco ahora
            agenda.huecosLibres();
        }
    }
}
