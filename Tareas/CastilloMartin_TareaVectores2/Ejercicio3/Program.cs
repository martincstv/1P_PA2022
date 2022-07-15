using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metodos;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Se quiere realizar un programa que lea por teclado las 5 notas obtenidas por un alumno
             * (comprendidas entre 0 y 10). A continuación debe mostrar todas las notas, la nota media, la
             * nota más alta que ha sacado y la menor.
             */
            Funcion fun = new Funcion();
            float[] notasAlumno = new float[5];
            int nota;
            for (int i = 0; i < notasAlumno.Length; i++)
            {
                Console.Write("Ingrese la nota: ");
                nota = Convert.ToInt32(Console.ReadLine());
                while (nota < 0 || nota > 10)
                {
                    Console.Write("Ingrese la nota: ");
                    nota = Convert.ToInt32(Console.ReadLine());
                }
                notasAlumno[i] = nota;
            }
            Console.WriteLine("     NOTAS");
            fun.ImprimirVector(notasAlumno);
            Console.WriteLine($"Nota media: {notasAlumno.Average()}");
            Console.WriteLine($"Nota maxima: {notasAlumno.Max()}");
            Console.WriteLine($"Nota minima: {notasAlumno.Min()}");
        }
    }
}
