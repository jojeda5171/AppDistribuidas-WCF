using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTA.FISEI.Prestamos.Dominio;

namespace UTA.FISEI.Prestamos.ContratoBD
{
    public interface IClienteBD
    {
        Cliente obtenerCliente(string numeroDocumento);
        IEnumerable<Cliente> listarCliente();
    }
}
