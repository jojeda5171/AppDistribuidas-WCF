using System;
using System.Runtime.Serialization;

namespace UTA.FISEI.Prestamos.Dominio
{
    [DataContract]
    public class Cliente
    {
        [DataMember]
        public int idCliente { get; set; }
        [DataMember]
        public string nombre { get; set; }
        [DataMember]
        public string apellidoPaterno { get; set; }
        [DataMember]
        public string apellidoMaterno { get; set; }
        [DataMember]
        public string tipoDocumento { get; set; }
        [DataMember]
        public string numeroDocumento { get; set; }
        [DataMember]
        public string sexo { get; set; }
        [DataMember]
        public DateTime fechaNacimiento { get; set; }
        [DataMember]
        public string direccion { get; set; }
        [DataMember]
        public string codigoPostal { get; set; }
        [DataMember]
        public string estadoCivil { get; set; }
    }

}
