using System;
using System.Collections.Generic;
using UTA.FISEI.Prestamos.Dominio;
using System.ServiceModel;

namespace UTA.FISEI.Prestamos.Contrato
{
    [ServiceContract]
    public interface IClienteService
    {
        [OperationContract]
        Cliente obtenerCliente(string numeroDocumento);
        [OperationContract]
        IEnumerable<Cliente> listarCliente();
    }
}
