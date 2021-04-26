using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceFCMySql.Modelos
{
    public partial class Genero
    {
        public Genero()
        {
            Personas = new HashSet<Persona>();
        }

        public int Idgenero { get; set; }
        public string Descripciongenero { get; set; }

        public virtual ICollection<Persona> Personas { get; set; }
    }
}
