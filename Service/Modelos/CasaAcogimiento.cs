using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceFC.Modelos
{
    public partial class CasaAcogimiento
    {
        public CasaAcogimiento()
        {
            HistorialCronologicos = new HashSet<HistorialCronologico>();
        }

        public int IdNombreCasaAnterior { get; set; }
        public string DescripcionCasaAcogimiento { get; set; }

        public virtual ICollection<HistorialCronologico> HistorialCronologicos { get; set; }
    }
}
