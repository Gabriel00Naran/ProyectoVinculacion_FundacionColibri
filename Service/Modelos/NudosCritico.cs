using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceFC.Modelos
{
    public partial class NudosCritico
    {
        public NudosCritico()
        {
            DatosJudicialPenals = new HashSet<DatosJudicialPenal>();
        }

        public int IdNudosCriticos { get; set; }
        public string DescripcionNudosCriticos { get; set; }

        public virtual ICollection<DatosJudicialPenal> DatosJudicialPenals { get; set; }
    }
}
