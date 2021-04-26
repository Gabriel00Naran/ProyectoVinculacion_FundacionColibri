using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceFCMySql.Modelos
{
    public partial class Nivelacademico
    {
        public Nivelacademico()
        {
            Pgfs = new HashSet<Pgf>();
        }

        public int Idnivelacademico { get; set; }
        public string Descripcionacademico { get; set; }

        public virtual ICollection<Pgf> Pgfs { get; set; }
    }
}
