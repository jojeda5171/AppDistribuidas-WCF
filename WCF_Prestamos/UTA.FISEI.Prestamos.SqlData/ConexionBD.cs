using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace UTA.FISEI.Prestamos.SqlData
{
    public class ConexionBD
    {
        public static string obtenerCadenaConexion()
        {
            return ConfigurationManager.ConnectionStrings["PrestamosBD"].ToString();
        }
    }
}
