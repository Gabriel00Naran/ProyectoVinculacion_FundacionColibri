using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceFC.Modelos
{
    public partial class FamiliarReferente
    {
        public FamiliarReferente()
        {
            Pgfs = new HashSet<Pgf>();
        }

        public int IdFamiliarReferente { get; set; }
        public string DescripcionFamiliarReferente { get; set; }

        public virtual ICollection<Pgf> Pgfs { get; set; }
    }
}
