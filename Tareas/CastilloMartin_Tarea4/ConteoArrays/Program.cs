using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConteoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Utilizando una cadena de texto, conviértalo a un array de caracteres
             * y especifique cuántos de esos elementos son: letras, consonantes y cuantas letras llevan tildes.
             */
            string tresNotas = @"Y es precisamente en ese momento
En que de mi mala suerte, yo me lamento
En que tú te apareces con tus caricias
Me besas la espalda, me das una sonrisa";
            var caracteres = tresNotas.ToCharArray();
            char[] vocales = { 'a', 'e', 'i', 'o', 'u', 'á', 'é', 'í', 'ó', 'ú' };
            char[] vocalesTildadas = { 'á', 'é', 'í', 'ó', 'ú' };
            int contadorLetras = 0, contadorConsonantes = 0, contadorTildes = 0;
            foreach (var item in caracteres)
            {
                if (char.IsLetter(item))
                {
                    foreach (var vocal in vocales)
                    {
                        if (item.Equals(vocal))
                        {
                            contadorConsonantes++;
                        }
                    }

                    foreach (var vocalTildada in vocalesTildadas)
                    {
                        if (item.Equals(vocalTildada))
                        {
                            contadorTildes++;
                        }
                    }
                    contadorLetras++;
                }
            }

            Console.WriteLine($"Cantidad de LETRAS : {contadorLetras}");
            Console.WriteLine($"Cantidad de CONSONANTES : {contadorLetras - contadorConsonantes}");
            Console.WriteLine($"Cantidad de LETRAS TILDADAS : {contadorTildes}");
        }
    }
}
