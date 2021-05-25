using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceFCMySql.Modelos
{
    public partial class Medidum
    {
        public Medidum()
        {
            Datosjudicialpenals = new HashSet<Datosjudicialpenal>();
        }

        public int Idmedida { get; set; }
        public string Descripcionmedida { get; set; }

        public virtual ICollection<Datosjudicialpenal> Datosjudicialpenals { get; set; }
    }
}
