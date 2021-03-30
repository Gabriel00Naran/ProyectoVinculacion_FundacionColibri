using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceFC.Modelos
{
    public partial class Provincium
    {
        public Provincium()
        {
            Cantons = new HashSet<Canton>();
            Personas = new HashSet<Persona>();
            Pgfs = new HashSet<Pgf>();
        }

        public int IdProvincia { get; set; }
        public string DescripcionProvincia { get; set; }

        public virtual ICollection<Canton> Cantons { get; set; }
        public virtual ICollection<Persona> Personas { get; set; }
        public virtual ICollection<Pgf> Pgfs { get; set; }
    }
}
