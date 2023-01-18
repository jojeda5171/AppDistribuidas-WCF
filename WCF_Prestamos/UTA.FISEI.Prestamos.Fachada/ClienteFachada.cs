using System;
using System.Collections.Generic;
//using UTA.FISEI.Prestamos.Implementacion;
using UTA.FISEI.Prestamos.Contrato;
using UTA.FISEI.Prestamos.Dominio;
using UTA.FISEI.Prestamos.ContratoBD;
using UTA.FISEI.Prestamos.SqlData;

namespace UTA.FISEI.Prestamos.Fachada
{
    public class ClienteFachada : IDisposable
    {
        public Cliente obtenerCliente(string numeroDocumento)
        {
            IClienteBD obj = new ClienteBD();
            return obj.obtenerCliente(numeroDocumento);

        }
        public IEnumerable<Cliente> listarCliente()
        {
            IClienteBD obj = new ClienteBD();
            return obj.listarCliente();

        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
