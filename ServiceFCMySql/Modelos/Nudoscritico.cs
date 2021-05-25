using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceFCMySql.Modelos
{
    public partial class Nudoscritico
    {
        public Nudoscritico()
        {
            Datosjudicialpenals = new HashSet<Datosjudicialpenal>();
        }

        public int Idnudoscriticos { get; set; }
        public string Descripcionnudoscriticos { get; set; }

        public virtual ICollection<Datosjudicialpenal> Datosjudicialpenals { get; set; }
    }
}
