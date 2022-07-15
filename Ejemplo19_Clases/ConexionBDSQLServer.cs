using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo19_Clases
{
    internal class ConexionBDSQLServer : IConexionBD
    {
        public bool Conectar(string cadenaConexion)
        {
            //logica de conexion a sql server
            return true;
        }

        public bool Desconectar()
        {
            //logica de desconexion de sql server
            return false;
        }

        public string EstadoConexion()
        {
            return "Activo";
        }

        public bool LevantarServicio()
        {
            return true;
        }
    }
}
