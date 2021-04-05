using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceFC.Modelos
{
    public partial class Pgf
    {
        public Guid IdPgf { get; set; }
        public Guid? IdPeronsa { get; set; }
        public int? IdFamiliarReferente { get; set; }
        public string NombreFamiliar { get; set; }
        public int? IdProvincia { get; set; }
        public int? IdCanton { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public bool? NnaInsertoSistemaEducativo { get; set; }
        public int? IdNivelAcademico { get; set; }

        public virtual Canton IdCantonNavigation { get; set; }
        public virtual FamiliarReferente IdFamiliarReferenteNavigation { get; set; }
        public virtual NivelAcademico IdNivelAcademicoNavigation { get; set; }
        public virtual Persona IdPeronsaNavigation { get; set; }
        public virtual Provincium IdProvinciaNavigation { get; set; }
    }
}
