using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceFCMySql.Modelos
{
    public partial class Provincium
    {
        public Provincium()
        {
            Cantons = new HashSet<Canton>();
            Personas = new HashSet<Persona>();
            Pgfs = new HashSet<Pgf>();
        }

        public int Idprovincia { get; set; }
        public string Descripcionprovincia { get; set; }

        public virtual ICollection<Canton> Cantons { get; set; }
        public virtual ICollection<Persona> Personas { get; set; }
        public virtual ICollection<Pgf> Pgfs { get; set; }
    }
}
