using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceFC.Modelos
{
    public partial class Canton
    {
        public Canton()
        {
            Parroquia = new HashSet<Parroquium>();
            Personas = new HashSet<Persona>();
            Pgfs = new HashSet<Pgf>();
        }

        public int IdCanton { get; set; }
        public string DescripcionCanton { get; set; }
        public int? IdProvincia { get; set; }

        public virtual Provincium IdProvinciaNavigation { get; set; }
        public virtual ICollection<Parroquium> Parroquia { get; set; }
        public virtual ICollection<Persona> Personas { get; set; }
        public virtual ICollection<Pgf> Pgfs { get; set; }
    }
}
