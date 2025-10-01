using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class Program
    {


        public static bool login(string usuario, string contraseña) {
            const string usuarioV = "usuario2DAM";
            const string contraseñaV = "pass2DAM";

            if (usuario.Equals(usuarioV) && contraseña.Equals(contraseñaV))
            {
                return true;
            }
            else {
                return false;
            } 
        
        }

        static void Main(string[] args)
        {
            int intentos = 3;
            bool loginCorrecto = false;


            for (int i = 2; i >= 0; i--)
            {
                Console.Write("Introduce el usuario: ");
                string usuario = Console.ReadLine();

                Console.Write("Introduce la contraseña: ");
                string contrasena = Console.ReadLine();

                loginCorrecto = login(usuario, contrasena);
                if (loginCorrecto)
                {
                    Console.WriteLine("Accediendo al sistema...");
                    break;
                }
                else
                {
                    Console.WriteLine("Usuario o contraseña incorrectos. Te quedan " + i + " intentos");
                }

            }
            
            if (!loginCorrecto)
            {
                Console.WriteLine("Has realizado demasiados intentos");
            }

   


    }
    }
}
