using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprueban_Reprueban
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Promedio de calificaciones de N estudiantes
             * *Cuantos* aprueban y reprueban
             */

            Console.Write("Ingrese la cantidad de estudiantes: ");
            int cantidadEstudiantes = Convert.ToInt32(Console.ReadLine());
            float[] calificaciones = new float[cantidadEstudiantes];
            for (int i = 0; i < cantidadEstudiantes; i++)
            {
                Console.Write("Estudiante[{0}]: ",i);
                calificaciones[i] = Convert.ToSingle(Console.ReadLine());
            }
            int aprobados = 0, reprobados = 0;
            foreach (var item in calificaciones)
            {
                if (item >= 7)
                    aprobados++;
                else
                    reprobados++;
            }
            Console.WriteLine($"Aprobados: {aprobados} - Reprobados: {reprobados}");
        }
    }
}
