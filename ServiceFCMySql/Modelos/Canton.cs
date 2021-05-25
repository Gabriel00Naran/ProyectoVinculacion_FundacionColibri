using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceFCMySql.Modelos
{
    public partial class Canton
    {
        public Canton()
        {
            Parroquia = new HashSet<Parroquium>();
            Personas = new HashSet<Persona>();
            Pgfs = new HashSet<Pgf>();
        }

        public int Idcanton { get; set; }
        public string Descripcioncanton { get; set; }
        public int? Idprovincia { get; set; }

        public virtual Provincium IdprovinciaNavigation { get; set; }
        public virtual ICollection<Parroquium> Parroquia { get; set; }
        public virtual ICollection<Persona> Personas { get; set; }
        public virtual ICollection<Pgf> Pgfs { get; set; }
    }
}
