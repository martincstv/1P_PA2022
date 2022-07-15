using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Fun
    {
        public enum TipoCredito
        {
            PRODUCTIVO_PYMES,
            PRODUCTIVO_EMPRESARIAL,
            PRODUCTIVO_CORPORATIVO,
            CONSUMO,
            MICROCREDITO,
            VIVIENDA,
            ESTUDIANTIL,
            MAESTRIAS,
            PHD
        }

        public enum SistemaAmortizacion
        {
            FRANCÉS_CUOTA_FIJA,
            ALEMAN_CUOTA_VARIABLE
        }
    }
}
