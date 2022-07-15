using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class Amortizacion
    {
        public int CuotaNo { get; set; }
        public float AbonoCapital { get; set; }
        public float Interes { get; set; }
        public float SeguroDesg { get; set; }
        public float Cuota { get; set; }
        public float Saldo { get; set; }

        public Amortizacion(int cuotaNo, float abonoCapital, float interes, float seguroDesg, float cuota, float saldo)
        {
            CuotaNo = cuotaNo;
            AbonoCapital = abonoCapital;
            Interes = interes;
            SeguroDesg = seguroDesg;
            Cuota = cuota;
            Saldo = saldo;
        }
    }
}
