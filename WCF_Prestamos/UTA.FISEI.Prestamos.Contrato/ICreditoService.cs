using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTA.FISEI.Prestamos.Dominio;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace UTA.FISEI.Prestamos.Contrato
{
    [ServiceContract]
    public interface ICreditoService
    {
        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/listarCredito", BodyStyle = WebMessageBodyStyle.Bare)]
        IEnumerable<Credito> listarCredito();

        [OperationContract]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST", UriTemplate = "/registrarCredito/", BodyStyle = WebMessageBodyStyle.Bare)]
        Credito registrarCredito(Credito credito);

        [OperationContract]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "PUT", UriTemplate = "/actualizarCredito/", BodyStyle = WebMessageBodyStyle.Bare)]
        Credito actualizarCredito(Credito credito);


        [OperationContract]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "DELETE", UriTemplate = "/eliminarCredito/{idCredito}", BodyStyle = WebMessageBodyStyle.Bare)]
        bool eliminarCredito(string idCredito);
    }
}
