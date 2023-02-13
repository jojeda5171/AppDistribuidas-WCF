using System;
using System.Collections.Generic;
using UTA.FISEI.Prestamos.Dominio;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace UTA.FISEI.Prestamos.Contrato
{
    [ServiceContract]
    public interface IClienteService
    {
        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/obtenerCliente/{numeroDocumento}", BodyStyle = WebMessageBodyStyle.Bare)]
        Cliente obtenerCliente(string numeroDocumento);
        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/listarCliente", BodyStyle = WebMessageBodyStyle.Bare)]
        IEnumerable<Cliente> listarCliente();
    }
}
