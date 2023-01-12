using System;
using System.Runtime.Serialization;

namespace UTA.FISEI.Prestamos.Dominio

{
    [DataContract]
    class Credito
    {
        [DataMember]
        public int idCreditp { get; set; }
        [DataMember]
        public string tipoCredito { get; set; }
        [DataMember]
        public int idCliente { get; set; }
        [DataMember]
        public DateTime fecha { get; set; }
        [DataMember]
        public float monto { get; set; }
        [DataMember]
        public DateTime diaPago { get; set; }
        [DataMember]
        public float tasa { get; set; }
        [DataMember]
        public float comision { get; set; }

    }
}
