using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTA.FISEI.Prestamos.Contrato;
using UTA.FISEI.Prestamos.Dominio;
using UTA.FISEI.Prestamos.Fachada;

namespace UTA.FISEI.Prestamos.Implementacion
{
    class CreditoService : ICreditoService
    {
        public IEnumerable<Credito> listarCredito()
        {
            using (var obj=new CreditoFachada())
            {
                return obj.listarCredito();
            }
        }

        public Credito registrarCredito(Credito credito)
        {
            using (var obj = new CreditoFachada())
            {
                return obj.registrarCredito(credito);
            }
        }
        public Credito actualizarCredito(Credito credito)
        {
            using (var obj = new CreditoFachada())
            {
                return obj.actualizarCredito(credito);
            }
        }

        public bool eliminarCredito(string idCredito)
        {
            using (var obj = new CreditoFachada())
            {
                return obj.eliminarCredito(idCredito);
            }
        }
    }
}
