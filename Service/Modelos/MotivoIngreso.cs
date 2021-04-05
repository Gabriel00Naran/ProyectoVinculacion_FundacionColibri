using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceFC.Modelos
{
    public partial class MotivoIngreso
    {
        public MotivoIngreso()
        {
            Personas = new HashSet<Persona>();
        }

        public int IdMotivoIngreso { get; set; }
        public string DescripcionMotivoIngreso { get; set; }

        public virtual ICollection<Persona> Personas { get; set; }
    }
}
