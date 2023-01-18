using Dapper;
using System.Collections.Generic;
using UTA.FISEI.Prestamos.Dominio;
using UTA.FISEI.Prestamos.ContratoBD;
using System.Data;
using System.Data.SqlClient;

namespace UTA.FISEI.Prestamos.SqlData
{
    public class ClienteBD : IClienteBD
    {
        public IEnumerable<Cliente> listarCliente()
        {

            using (IDbConnection conexion = new SqlConnection(ConexionBD.obtenerCadenaConexion()))
            {
                conexion.Open();
                var cliente = conexion.Query<Cliente>("dbo.sp_listar_cliente", commandType: CommandType.StoredProcedure);
                return cliente;
            }
        }

        public Cliente obtenerCliente(string numeroDocumento)

        {

            using (IDbConnection conexion = new SqlConnection(ConexionBD.obtenerCadenaConexion()))
            {
                conexion.Open();
                var parametros = new DynamicParameters();
                parametros.Add("pNumeroDocumeto", numeroDocumento);
                var cliente = conexion.QuerySingle<Cliente>("dbo.sp_obtener_cliente", param: parametros, commandType: CommandType.StoredProcedure);
                return cliente;
            }

        }
    }
}
