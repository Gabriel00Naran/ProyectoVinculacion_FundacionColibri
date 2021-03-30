using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceFC.Modelos
{
    public partial class Organizacion
    {
        public Organizacion()
        {
            Personas = new HashSet<Persona>();
        }

        public int IdOrganizacion { get; set; }
        public string DescripcionOrganizacion { get; set; }

        public virtual ICollection<Persona> Personas { get; set; }
    }
}
