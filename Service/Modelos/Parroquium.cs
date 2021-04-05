using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceFC.Modelos
{
    public partial class Parroquium
    {
        public Parroquium()
        {
            Personas = new HashSet<Persona>();
        }

        public int IdParroquia { get; set; }
        public string DescripcionParroquia { get; set; }
        public int? IdCanton { get; set; }

        public virtual Canton IdCantonNavigation { get; set; }
        public virtual ICollection<Persona> Personas { get; set; }
    }
}
