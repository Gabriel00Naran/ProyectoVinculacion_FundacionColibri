using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceFCMySql.Modelos
{
    public partial class Nacionalidad
    {
        public Nacionalidad()
        {
            Personas = new HashSet<Persona>();
        }

        public int Idnacionalidad { get; set; }
        public string Descripcionnacionalidad { get; set; }

        public virtual ICollection<Persona> Personas { get; set; }
    }
}
