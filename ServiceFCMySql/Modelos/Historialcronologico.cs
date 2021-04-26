using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceFCMySql.Modelos
{
    public partial class Historialcronologico
    {
        public int Idhistorial { get; set; }
        public int? Idpersona { get; set; }
        public bool? Estuboacogimiento { get; set; }
        public int? Idnombrecasaanterior { get; set; }
        public DateTime? Fechaegreso { get; set; }
        public DateTime? Fechaingreso { get; set; }

        public virtual Casaacogimiento IdnombrecasaanteriorNavigation { get; set; }
        public virtual Persona IdpersonaNavigation { get; set; }
    }
}
