using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTA.FISEI.Prestamos.Dominio;

namespace UTA.FISEI.Prestamos.ContratoBD
{
    public interface ICreditoBD
    {
        IEnumerable<Credito> listarCredito();

        Credito registrarCredito(Credito credito);

        Credito actualizarCredito(Credito credito);

        bool eliminarCredito(string idCredito);
    }
}
