using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTA.FISEI.Prestamos.ContratoBD;
using UTA.FISEI.Prestamos.Dominio;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace UTA.FISEI.Prestamos.SqlData
{
    public class CreditoBD : ICreditoBD
    {
        public IEnumerable<Credito> listarCredito()
        {
            using (IDbConnection conexion = new SqlConnection(ConexionBD.obtenerCadenaConexion()))
            {
                conexion.Open();
                var credito = conexion.Query<Credito>("dbo.sp_credito_listar", commandType: CommandType.StoredProcedure);
                return credito;
            }
        }

        public Credito registrarCredito(Credito credito)
        {
            using (IDbConnection conexion = new SqlConnection(ConexionBD.obtenerCadenaConexion()))
            {
                conexion.Open();
                var parametros = new DynamicParameters();
                parametros.Add("TipoCredito", credito.tipoCredito);
                parametros.Add("IdCliente", credito.idCliente);
                parametros.Add("Fecha", credito.fecha);
                parametros.Add("Monto", credito.monto);
                parametros.Add("DiaPago", credito.diaPago);
                parametros.Add("Tasa", credito.tasa);
                parametros.Add("Comision", credito.comision);
                parametros.Add("IdCredito", credito.idCreditp, DbType.Int32, ParameterDirection.Output);
                var result = conexion.ExecuteScalar("dbo.sp_credito_registrar", param: parametros, commandType: CommandType.StoredProcedure);
                //var result = conexion.ExecuteScalar("dbo.sp_credito_registrar", param: parametros, commandType: CommandType.StoredProcedure);
                var pIdCredito = parametros.Get<Int32>("IdCredito");
                credito.idCreditp = pIdCredito;
                return credito;
            }
        }

        public Credito actualizarCredito(Credito credito)
        {
            using (IDbConnection conexion = new SqlConnection(ConexionBD.obtenerCadenaConexion()))
            {
                conexion.Open();
                var parametros = new DynamicParameters();
                parametros.Add("IdCredito", credito.idCreditp);
                parametros.Add("TipoCredito", credito.tipoCredito);
                parametros.Add("IdCliente", credito.idCliente);
                parametros.Add("Fecha", credito.fecha);
                parametros.Add("Monto", credito.monto);
                parametros.Add("DiaPago", credito.diaPago);
                parametros.Add("Tasa", credito.tasa);
                parametros.Add("Comision", credito.comision);
                var result = conexion.Execute("dbo.sp_credito_actualizar", param: parametros, commandType: CommandType.StoredProcedure);
                return result>0 ? credito:new Credito();
            }
        }

        public bool eliminarCredito(string idCredito)
        {
            using (IDbConnection conexion = new SqlConnection(ConexionBD.obtenerCadenaConexion()))
            {
                conexion.Open();
                var parametros = new DynamicParameters();
                parametros.Add("IdCredito", idCredito);
                var result = conexion.Execute("dbo.sp_credito_eliminar", param: parametros, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }
    }
}
