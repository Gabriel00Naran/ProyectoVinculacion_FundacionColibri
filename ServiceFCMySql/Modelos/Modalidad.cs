using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceFCMySql.Modelos
{
    public partial class Modalidad
    {
        public Modalidad()
        {
            Personas = new HashSet<Persona>();
        }

        public int Idmodalidad { get; set; }
        public string Descripcionmodalidad { get; set; }

        public virtual ICollection<Persona> Personas { get; set; }
    }
}
