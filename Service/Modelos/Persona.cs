using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceFC.Modelos
{
    public partial class Persona
    {
        public Persona()
        {
            DatosJudicialPenals = new HashSet<DatosJudicialPenal>();
            DatosSaluds = new HashSet<DatosSalud>();
            HistorialCronologicos = new HashSet<HistorialCronologico>();
            Pgfs = new HashSet<Pgf>();
        }

        public Guid IdPersona { get; set; }
        public int? IdOrganizacion { get; set; }
        public int? IdModalidad { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NombreCompleto { get; set; }
        public string Telefono { get; set; }
        public string DocumentoIdentidad { get; set; }
        public int? IdGenero { get; set; }
        public int? IdEtnia { get; set; }
        public int? IdNacionalidad { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string Edad { get; set; }
        public int? IdProvincia { get; set; }
        public int? IdCanton { get; set; }
        public int? IdParroquia { get; set; }
        public string Barrio { get; set; }
        public string Direccion { get; set; }
        public DateTime? FechaDeIngresoUnidadAtencion { get; set; }
        public string EdadIngreso { get; set; }
        public string TiempoPermanenciaAnnios { get; set; }
        public int? IdMotivoIngreso { get; set; }

        public virtual Canton IdCantonNavigation { get; set; }
        public virtual Etnium IdEtniaNavigation { get; set; }
        public virtual Genero IdGeneroNavigation { get; set; }
        public virtual Modalidad IdModalidadNavigation { get; set; }
        public virtual MotivoIngreso IdMotivoIngresoNavigation { get; set; }
        public virtual Nacionalidad IdNacionalidadNavigation { get; set; }
        public virtual Organizacion IdOrganizacionNavigation { get; set; }
        public virtual Parroquium IdParroquiaNavigation { get; set; }
        public virtual Provincium IdProvinciaNavigation { get; set; }
        public virtual ICollection<DatosJudicialPenal> DatosJudicialPenals { get; set; }
        public virtual ICollection<DatosSalud> DatosSaluds { get; set; }
        public virtual ICollection<HistorialCronologico> HistorialCronologicos { get; set; }
        public virtual ICollection<Pgf> Pgfs { get; set; }
    }
}
