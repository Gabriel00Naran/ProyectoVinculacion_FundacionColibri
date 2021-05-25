using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceFCMySql.Modelos
{
    public partial class Casaacogimiento
    {
        public Casaacogimiento()
        {
            Historialcronologicos = new HashSet<Historialcronologico>();
        }

        public int Idnombrecasaanterior { get; set; }
        public string Descripcioncasaacogimiento { get; set; }

        public virtual ICollection<Historialcronologico> Historialcronologicos { get; set; }
    }
}
