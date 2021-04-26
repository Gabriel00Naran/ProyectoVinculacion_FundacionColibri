using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceFCMySql.Modelos
{
    public partial class Familiarreferente
    {
        public Familiarreferente()
        {
            Pgfs = new HashSet<Pgf>();
        }

        public int Idfamiliarreferente { get; set; }
        public string Descripcionfamiliarreferente { get; set; }

        public virtual ICollection<Pgf> Pgfs { get; set; }
    }
}
