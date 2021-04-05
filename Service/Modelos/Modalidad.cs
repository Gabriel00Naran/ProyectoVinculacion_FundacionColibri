using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceFC.Modelos
{
    public partial class Modalidad
    {
        public Modalidad()
        {
            Personas = new HashSet<Persona>();
        }

        public int IdModalidad { get; set; }
        public string DescripcionModalidad { get; set; }

        public virtual ICollection<Persona> Personas { get; set; }
    }
}
