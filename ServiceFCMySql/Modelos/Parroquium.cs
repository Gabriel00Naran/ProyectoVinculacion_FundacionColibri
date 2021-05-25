using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceFCMySql.Modelos
{
    public partial class Parroquium
    {
        public Parroquium()
        {
            Personas = new HashSet<Persona>();
        }

        public int Idparroquia { get; set; }
        public string Descripcionparroquia { get; set; }
        public int? Idcanton { get; set; }

        public virtual Canton IdcantonNavigation { get; set; }
        public virtual ICollection<Persona> Personas { get; set; }
    }
}
