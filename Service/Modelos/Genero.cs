using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceFC.Modelos
{
    public partial class Genero
    {
        public Genero()
        {
            Personas = new HashSet<Persona>();
        }

        public int IdGenero { get; set; }
        public string DescripcionGenero { get; set; }

        public virtual ICollection<Persona> Personas { get; set; }
    }
}
