using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Crear un programa de ordenador para gestionar los resultados de la quiniela de fútbol. Para 
             * ello vamos a utilizar dos tablas:
             * 
             * • Equipos: Que es una tabla de cadenas donde guardamos en cada columna el nombre 
             * de los equipos de cada partido. En la quiniela se indican 15 partidos.
             * 
             * • Resultados: Es una tabla de enteros donde se indica el resultado. También tiene dos 
             * columnas, en la primera se guarda el número de goles del equipo que está guardado 
             * en la primera columna de la tabla anterior, y en la segunda los goles del otro equipo.
             * 
             * 
             * El programa ira pidiendo los nombres de los equipos de cada partido y el resultado del partido, 
             * a continuación se imprimirá la quiniela de esa jornada.
             * 
             * ¿Qué modificación habría que hacer en las tablas para guardar todos los resultados de todas 
             * las jornadas de la temporada?
             */
            string[,] equipos = new string[15, 2];
            int[,] resultados = new int[15, 2];
            for (int fila = 0; fila < equipos.GetLength(0); fila++)
            {
                for (int columna = 0; columna < equipos.GetLength(1); columna++)
                {
                    Console.Write($"Ingresar equipo [{columna + 1}]: ");
                    equipos[fila, columna] = Console.ReadLine();
                    Console.Write($"Ingresar resultado [{columna + 1}]: ");
                    resultados[fila, columna] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine($"        Equipos partido   =>  Resultados partido \n");
            for (int i = 0; i < equipos.GetLength(0); i++)
            {
                Console.WriteLine($"{equipos[i, 0]} - {equipos[i, 1]}   =>  {resultados[i, 0]} - {resultados[i, 1]} ");
            }
        }
    }
}
