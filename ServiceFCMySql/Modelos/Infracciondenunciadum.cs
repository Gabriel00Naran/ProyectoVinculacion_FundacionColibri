using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceFCMySql.Modelos
{
    public partial class Infracciondenunciadum
    {
        public Infracciondenunciadum()
        {
            Datosjudicialpenals = new HashSet<Datosjudicialpenal>();
        }

        public int Idinfracciondenunciada { get; set; }
        public string Descripcioninfracciondenuncia { get; set; }

        public virtual ICollection<Datosjudicialpenal> Datosjudicialpenals { get; set; }
    }
}
