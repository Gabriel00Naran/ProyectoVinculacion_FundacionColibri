using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceFC.Modelos
{
    public partial class HistorialCronologico
    {
        public Guid IdHistorial { get; set; }
        public Guid? IdPersona { get; set; }
        public bool? EstuvoAcogimiento { get; set; }
        public int? IdNombreCasaAnterior { get; set; }
        public DateTime? FechaEgreso { get; set; }
        public DateTime? FechaIngreso { get; set; }

        public virtual CasaAcogimiento IdNombreCasaAnteriorNavigation { get; set; }
        public virtual Persona IdPersonaNavigation { get; set; }
    }
}
