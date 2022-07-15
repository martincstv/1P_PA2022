using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metodos;

namespace Ejercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Crear un programa que lea los precios de 5 artículos y las cantidades vendidas por una 
             * empresa en sus 4 sucursales. Informar:
             * • Las cantidades totales de cada articulo.
             * • La cantidad de artículos en la sucursal 2.
             * • La cantidad del articulo 3 en la sucursal 1.
             * • La recaudación total de cada sucursal.
             * • La recaudación total de la empresa.
             * • La sucursal de mayor recaudación.
             */
            Funcion fun = new Funcion();
            string[] articulos = new string[5];
            int[,] cantidadesVendidas = new int[5, 4] {{1,2,3,4},
                                                       {5,6,7,8},
                                                       {9,10,11,12},
                                                       {13,14,15,16},
                                                       {177,18,19,20}};
            int[] cantidadesTotales = new int[5];
            int articulosSucursal2 = 0;
            int articulo3Sucursal1 = cantidadesVendidas[2, 0];
            int[] recaudacionSucursal = new int[4];
            int recaudacionTotal = 0;
            string producto;
            //for (int fila = 0; fila < cantidadesVendidas.GetLength(0); fila++)
            //{
            //    producto = fun.LecturaCadena("Ingrese el nombre del articulo");
            //    articulos[fila] = producto;
            //    for (int columna = 0; columna < cantidadesVendidas.GetLength(1); columna++)
            //    {

            //        Console.Write($"Ingrese la cantidad vendida [{columna + 1}]: ");
            //        cantidadesVendidas[fila,columna] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            for (int articulo = 0; articulo < cantidadesVendidas.GetLength(0); articulo++)
            {
                for (int sucursal = 0; sucursal < cantidadesVendidas.GetLength(1); sucursal++)
                {
                    cantidadesTotales[articulo] += cantidadesVendidas[articulo, sucursal];
                }
            }

            for (int i = 0; i < cantidadesVendidas.GetLength(0); i++)
            {
                articulosSucursal2 += cantidadesVendidas[i, 1];
            }

            for (int columna = 0; columna < cantidadesVendidas.GetLength(1); columna++)
            {
                for (int fila = 0; fila < cantidadesVendidas.GetLength(0); fila++)
                {
                    recaudacionSucursal[columna] += cantidadesVendidas[fila, columna];
                }
            }

            for (int fila = 0; fila < cantidadesVendidas.GetLength(0); fila++)
            {
                for (int columna = 0; columna < cantidadesVendidas.GetLength(1); columna++)
                {
                    recaudacionTotal += cantidadesVendidas[fila, columna];
                }
            }

            var sucursalMayorRecaudacion = Array.IndexOf(recaudacionSucursal, recaudacionSucursal.Max()) + 1;





        }
    }
}
