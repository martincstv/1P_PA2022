using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo19_Clases
{
    internal interface IConexionBD
    {
        bool Conectar(string cadenaConexion);
        bool Desconectar();
        string EstadoConexion();
        bool LevantarServicio();

    }
}
