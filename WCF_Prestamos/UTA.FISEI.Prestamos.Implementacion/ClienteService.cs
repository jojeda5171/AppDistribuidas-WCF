using System;
using System.Collections.Generic;
using UTA.FISEI.Prestamos.Contrato;
using UTA.FISEI.Prestamos.Dominio;
using UTA.FISEI.Prestamos.Fachada;
namespace UTA.FISEI.Prestamos.Implementacion
{
    public class ClienteService : IClienteService
    {
        public Cliente obtenerCliente(String numeroDocumento)
        {
            ClienteFachada obj = new ClienteFachada();
            return obj.obtenerCliente(numeroDocumento);
        }

        public IEnumerable <Cliente> listarCliente()
        {
            ClienteFachada obj = new ClienteFachada();
            return obj.listarCliente();
        }
    }
}
