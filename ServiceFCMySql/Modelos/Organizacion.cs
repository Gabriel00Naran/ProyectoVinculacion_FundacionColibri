using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceFCMySql.Modelos
{
    public partial class Organizacion
    {
        public Organizacion()
        {
            Personas = new HashSet<Persona>();
        }

        public int Idorganizacion { get; set; }
        public string Descripcionorganizacion { get; set; }

        public virtual ICollection<Persona> Personas { get; set; }
    }
}
