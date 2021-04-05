using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceFC.Modelos
{
    public partial class DatosJudicialPenal
    {
        public Guid IdJudicialPenal { get; set; }
        public Guid? IdPersona { get; set; }
        public int? IdMedida { get; set; }
        public int? IdProvincia { get; set; }
        public string NºcausaAcogimiento { get; set; }
        public string UnidadJudicial { get; set; }
        public int? IdCanton { get; set; }
        public int? IdNudosCriticos { get; set; }
        public bool? ExisteCausaPenal { get; set; }
        public bool? EncuentraInsertSpavt { get; set; }
        public int? IdInfraccionDenunciada { get; set; }
        public string DescripcionDelito { get; set; }
        public string NºcasoFiscalia { get; set; }
        public string NºprocesoPenaleSatje { get; set; }
        public int? IdEstadoProcesal { get; set; }
        public bool? EgresoPorReinsercion { get; set; }
        public DateTime? FechaReinsercion { get; set; }
        public DateTime? FechaEgreso { get; set; }
        public DateTime? FechaResolucionTraslado { get; set; }
        public string UnidadTraslado { get; set; }
        public DateTime? FechaSalidaUnidadActual { get; set; }
        public string Observacion { get; set; }

        public virtual EstadoProcesal IdEstadoProcesalNavigation { get; set; }
        public virtual InfraccionDenunciadum IdInfraccionDenunciadaNavigation { get; set; }
        public virtual Medidum IdMedidaNavigation { get; set; }
        public virtual NudosCritico IdNudosCriticosNavigation { get; set; }
        public virtual Persona IdPersonaNavigation { get; set; }
    }
}
