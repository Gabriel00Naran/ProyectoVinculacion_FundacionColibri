using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceFCMySql.Modelos
{
    public partial class Estadoprocesal
    {
        public Estadoprocesal()
        {
            Datosjudicialpenals = new HashSet<Datosjudicialpenal>();
        }

        public int Idestadoprocesal { get; set; }
        public string Descripcionprocesal { get; set; }

        public virtual ICollection<Datosjudicialpenal> Datosjudicialpenals { get; set; }
    }
}
