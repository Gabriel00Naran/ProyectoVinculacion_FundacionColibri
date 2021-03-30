using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceFC.Modelos
{
    public partial class Etnium
    {
        public Etnium()
        {
            Personas = new HashSet<Persona>();
        }

        public int IdEtnia { get; set; }
        public string DescripcionEtnia { get; set; }

        public virtual ICollection<Persona> Personas { get; set; }
    }
}
