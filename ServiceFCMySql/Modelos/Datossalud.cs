using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceFCMySql.Modelos
{
    public partial class Datossalud
    {
        public int Iddatossalud { get; set; }
        public int? Idpersona { get; set; }
        public string Estadosalud { get; set; }
        public string Detalleenfermedad { get; set; }
        public bool? Medicacion { get; set; }
        public bool? Adolescenteperdiodogestacion { get; set; }
        public bool? Algunadiscapacidad { get; set; }
        public string Tipodiscapacidad { get; set; }
        public string Porcentajediscapacidad { get; set; }
        public string Numerocarnet { get; set; }
    }
}
