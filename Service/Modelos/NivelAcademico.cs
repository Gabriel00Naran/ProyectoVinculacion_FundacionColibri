using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceFC.Modelos
{
    public partial class NivelAcademico
    {
        public NivelAcademico()
        {
            Pgfs = new HashSet<Pgf>();
        }

        public int IdNivelAcademico { get; set; }
        public string DescripcionAcademico { get; set; }

        public virtual ICollection<Pgf> Pgfs { get; set; }
    }
}
