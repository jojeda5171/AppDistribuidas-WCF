using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTA.FISEI.Prestamos.Contrato;
using UTA.FISEI.Prestamos.Dominio;
using UTA.FISEI.Prestamos.ContratoBD;
using UTA.FISEI.Prestamos.SqlData;

namespace UTA.FISEI.Prestamos.Fachada
{
    public class CreditoFachada:IDisposable
    {
        public IEnumerable<Credito> listarCredito()
        {
            ICreditoBD obj = new CreditoBD();
            return obj.listarCredito();
        }

        public Credito registrarCredito(Credito credito)
        {
            ICreditoBD obj = new CreditoBD();
            return obj.registrarCredito(credito);
        }

        public Credito actualizarCredito(Credito credito)
        {
            ICreditoBD obj = new CreditoBD();
            return obj.actualizarCredito(credito);
        }

        public bool eliminarCredito(string idCredito)
        {
            ICreditoBD obj = new CreditoBD();
            return obj.eliminarCredito(idCredito);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
