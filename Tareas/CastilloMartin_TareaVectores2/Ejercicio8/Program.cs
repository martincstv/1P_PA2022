using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metodos;

namespace Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Queremos guardar los nombres y la edades de los alumnos de un curso. Realiza un programa 
             * que introduzca el nombre y la edad de cada alumno. El proceso de lectura de datos terminará 
             * cuando se introduzca como nombre un asterisco (*) Al finalizar se mostrará los siguientes 
             * datos:
             * • Todos lo alumnos mayores de edad.
             * • Los alumnos mayores (los que tienen más edad)
             */
            List<string> nombres = new List<string>();
            List<int> edades = new List<int>();
            string nombre;
            int edad;
            do
            {
                Console.Write("Nombre: ");
                nombre = Console.ReadLine();
                if (nombre != "*")
                {
                    Console.Write("Edad: ");
                    edad = Convert.ToInt32(Console.ReadLine());
                    nombres.Add(nombre);
                    edades.Add(edad);
                }
            } while (nombre != "*");
            Console.WriteLine("     MAYORES DE EDAD");
            for (int i = 0; i < nombres.Count; i++)
            {
                if (edades[i] >=18)
                {
                    Console.WriteLine($"{nombres[i]}");
                }
            }



        }
    }
}
