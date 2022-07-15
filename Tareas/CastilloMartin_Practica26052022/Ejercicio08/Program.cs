using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Encriptar y desencriptar un mensaje
             */
            int option;
            string mensaje;


            do
            {
                Leyenda();
                option = Convert.ToInt32(Console.ReadLine());
                Seleccion(option);
            } while (option < 1 || option > 2);


        }

        private static void Leyenda()
        {
            Console.WriteLine("1.-  Encriptar");
            Console.WriteLine("2.-  Desencriptar");
        }
        private static void Seleccion(int option)
        {
            string mensaje;
            char[] caracteresMensaje;
            switch (option)
            {
                case 1:
                    Console.Write("Ingrese el mensaje a encriptar: ");
                    mensaje = Console.ReadLine();
                    caracteresMensaje = mensaje.ToCharArray();
                    Encriptar(caracteresMensaje);
                    MostrarMensaje(caracteresMensaje);
                    break;
                case 2:
                    Console.Write("Ingrese el mensaje a desencriptar: ");
                    mensaje = Console.ReadLine();
                    caracteresMensaje = mensaje.ToCharArray();
                    Desencriptar(caracteresMensaje);
                    MostrarMensaje(caracteresMensaje);
                    break;
                default:
                    Console.WriteLine("Opcion no valida..!");
                    break;
            }
        }
        private static void Encriptar(char[] caracteresMensaje)
        {
            for (int i = 0; i < caracteresMensaje.Length; i++)
            {
                int ascii = (int)caracteresMensaje[i];
                int encriptacion = ascii + 5;
                caracteresMensaje[i] = (char)encriptacion;
            }
        }

        private static void Desencriptar(char[] caracteresMensaje)
        {
            for (int i = 0; i < caracteresMensaje.Length; i++)
            {
                int ascii = (int)caracteresMensaje[i];
                int desencriptacion = ascii - 5;
                caracteresMensaje[i] = (char)desencriptacion;
            }
        }

        private static void MostrarMensaje(char[] caracteresMensaje)
        {
            foreach (var item in caracteresMensaje)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
