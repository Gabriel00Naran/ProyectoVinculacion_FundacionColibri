using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceFCMySql.Modelos
{
    public partial class Motivoingreso
    {
        public Motivoingreso()
        {
            Personas = new HashSet<Persona>();
        }

        public int Idmotivoingreso { get; set; }
        public string Descripcionmotivoingreso { get; set; }

        public virtual ICollection<Persona> Personas { get; set; }
    }
}
