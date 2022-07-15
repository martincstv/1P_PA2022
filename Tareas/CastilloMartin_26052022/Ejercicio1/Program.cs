using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;
            do
            {
                Leyenda();
                Console.Write("Elija una opción: ");
                option = Convert.ToInt32(Console.ReadLine());
            } while (option < 1 || option > 3);
            Seleccion(option);
            

        }

        static void Leyenda()
        {
            Console.WriteLine("--------------IDIOMAS--------------");
            Console.WriteLine("1.- Español - Spanish - Espagnol");
            Console.WriteLine("2.- Ingles - English - Anglais");
            Console.WriteLine("3.- Frances - French - Français");
        }

        static void Seleccion(int option)
        {
            switch (option)
            {
                case 1:
                    Español();
                    break;
                case 2:
                    Ingles();
                    break;
                case 3:
                    Frances();
                    break;
                default:
                    break;
            }
        }

        static void Español()
        {
            Español español = new Español();
            español.Saludar();
            español.Agradecer();
            español.Despedirse();
            español.Pedir_Ayuda();
            español.Ayudar();
            español.NoEntiendo();

        }

        static void Ingles()
        {
            Ingles ingles = new Ingles();
            ingles.Saludar();
            ingles.Saludar();
            ingles.Agradecer();
            ingles.Despedirse();
            ingles.Pedir_Ayuda();
            ingles.Ayudar();
            ingles.NoEntiendo();

        }

        static void Frances()
        {
            Frances frances = new Frances();
            frances.Saludar();
            frances.Saludar();
            frances.Agradecer();
            frances.Despedirse();
            frances.Pedir_Ayuda();
            frances.Ayudar();
            frances.NoEntiendo();
        }
    }
}
