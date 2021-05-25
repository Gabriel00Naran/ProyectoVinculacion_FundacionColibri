using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceFCMySql.Modelos
{
    public partial class Datosjudicialpenal
    {
        public int Idjudicialpenal { get; set; }
        public int? Idpersona { get; set; }
        public int? Idmedida { get; set; }
        public int? Idprovincia { get; set; }
        public string Ncausaacogimiento { get; set; }
        public string Unidadjudicial { get; set; }
        public int? Idcanton { get; set; }
        public int? Idnudoscriticos { get; set; }
        public bool? Existecausapenal { get; set; }
        public bool? EncuentrainsertSpavt { get; set; }
        public int? Idinfracciondenunciada { get; set; }
        public string Descripciondelito { get; set; }
        public string Ncasofiscalia { get; set; }
        public string Nprocesopenalesatje { get; set; }
        public int? Idestadoprocesal { get; set; }
        public bool? Egresoporreinsercion { get; set; }
        public DateTime? Fechareinsercion { get; set; }
        public DateTime? Fechaegreso { get; set; }
        public DateTime? Fecharesoluciontraslado { get; set; }
        public string Unidadtraslado { get; set; }
        public DateTime? Fechasalidaunidadactual { get; set; }
        public string Observacion { get; set; }

        public virtual Estadoprocesal IdestadoprocesalNavigation { get; set; }
        public virtual Infracciondenunciadum IdinfracciondenunciadaNavigation { get; set; }
        public virtual Medidum IdmedidaNavigation { get; set; }
        public virtual Nudoscritico IdnudoscriticosNavigation { get; set; }
        public virtual Persona IdpersonaNavigation { get; set; }
    }
}
