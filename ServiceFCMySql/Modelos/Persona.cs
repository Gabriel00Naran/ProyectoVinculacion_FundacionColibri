using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceFCMySql.Modelos
{
    public partial class Persona
    {
        public Persona()
        {
            Datosjudicialpenals = new HashSet<Datosjudicialpenal>();
            Historialcronologicos = new HashSet<Historialcronologico>();
            Pgfs = new HashSet<Pgf>();
        }

        public int Idpersona { get; set; }
        public int? Idorganizacion { get; set; }
        public int? Idmodalidad { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Nombrecompleto { get; set; }
        public string Telefono { get; set; }
        public string Documentoidentidad { get; set; }
        public int? Idgenero { get; set; }
        public int? Idetnia { get; set; }
        public int? Idnacionalidad { get; set; }
        public DateTime? Fechanacimiento { get; set; }
        public DateTime? Fecharegistro { get; set; }
        public string Edad { get; set; }
        public int? Idprovincia { get; set; }
        public int? Idcanton { get; set; }
        public int? Idparroquia { get; set; }
        public string Barrio { get; set; }
        public string Direccion { get; set; }
        public DateTime? Fechadeingresounidadatencion { get; set; }
        public string Edadingreso { get; set; }
        public string Tiempopermanenciaannios { get; set; }
        public int? Idmotivoingreso { get; set; }

        public virtual Canton IdcantonNavigation { get; set; }
        public virtual Etnium IdetniaNavigation { get; set; }
        public virtual Genero IdgeneroNavigation { get; set; }
        public virtual Modalidad IdmodalidadNavigation { get; set; }
        public virtual Motivoingreso IdmotivoingresoNavigation { get; set; }
        public virtual Nacionalidad IdnacionalidadNavigation { get; set; }
        public virtual Organizacion IdorganizacionNavigation { get; set; }
        public virtual Parroquium IdparroquiaNavigation { get; set; }
        public virtual Provincium IdprovinciaNavigation { get; set; }
        public virtual ICollection<Datosjudicialpenal> Datosjudicialpenals { get; set; }
        public virtual ICollection<Historialcronologico> Historialcronologicos { get; set; }
        public virtual ICollection<Pgf> Pgfs { get; set; }
    }
}
