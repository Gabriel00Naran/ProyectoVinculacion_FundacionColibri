using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceFC.Modelos
{
    public partial class EstadoProcesal
    {
        public EstadoProcesal()
        {
            DatosJudicialPenals = new HashSet<DatosJudicialPenal>();
        }

        public int IdEstadoProcesal { get; set; }
        public string DescripcionProcesal { get; set; }

        public virtual ICollection<DatosJudicialPenal> DatosJudicialPenals { get; set; }
    }
}
