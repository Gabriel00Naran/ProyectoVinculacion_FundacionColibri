using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceFC.Modelos
{
    public partial class InfraccionDenunciadum
    {
        public InfraccionDenunciadum()
        {
            DatosJudicialPenals = new HashSet<DatosJudicialPenal>();
        }

        public int IdInfraccionDenunciada { get; set; }
        public string DescripcionInfraccionDenuncia { get; set; }

        public virtual ICollection<DatosJudicialPenal> DatosJudicialPenals { get; set; }
    }
}
