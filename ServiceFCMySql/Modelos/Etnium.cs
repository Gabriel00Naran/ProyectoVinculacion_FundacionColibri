using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceFCMySql.Modelos
{
    public partial class Etnium
    {
        public Etnium()
        {
            Personas = new HashSet<Persona>();
        }

        public int Idetnia { get; set; }
        public string Descripcionetnia { get; set; }

        public virtual ICollection<Persona> Personas { get; set; }
    }
}
