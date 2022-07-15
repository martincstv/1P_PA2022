using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo16_Enumeraciones
{
    internal class Program
    {
        enum DiasSemana
        {
            domingo,
            lunes,
            martes,
            miercoles,
            jueves,
            viernes,
            sabado
        }
        enum MesesAño
        {
            Enero,
            Febrero,
            Marzo,
            Abril,
            Mayo,
            Junio,
            Julio,
            Agosto,
            Septiembre,
            Octubre,
            Noviembre,
            Diciembre
        }
        enum Descuentos:byte
        {
            Basico = 10,
            Medio = 30,
            Alto = 50
        }
        static void Main(string[] args)
        {
            Console.WriteLine("El dia {0} tenemos el 15% de descuento",DiasSemana.jueves);
            Console.WriteLine("Valor: {0}",(int)DiasSemana.viernes);
            Console.WriteLine("Nos encontramos en el mes de {0}",MesesAño.Mayo);
            Console.WriteLine("Valor: {0}", (int)MesesAño.Mayo);
            Console.WriteLine("Descuento de hoy {0} es de {1} %",DiasSemana.jueves,(byte)Descuentos.Alto);

            //Recorrre todos los valors de una enumeracion
            foreach (var item in Enum.GetNames(typeof(MesesAño)))
            {
                Console.WriteLine(item);
            }

            MesesAño mes = MesesAño.Septiembre;
        }
    }
}
