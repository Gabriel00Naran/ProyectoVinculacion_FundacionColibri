using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceFC.Modelos
{
    public partial class Medidum
    {
        public Medidum()
        {
            DatosJudicialPenals = new HashSet<DatosJudicialPenal>();
        }

        public int IdMedida { get; set; }
        public string DescripcionMedida { get; set; }

        public virtual ICollection<DatosJudicialPenal> DatosJudicialPenals { get; set; }
    }
}
