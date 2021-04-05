using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceFC.Modelos
{
    public partial class DatosSalud
    {
        public Guid IdDatosSalud { get; set; }
        public Guid? IdPersona { get; set; }
        public string EstadoSalud { get; set; }
        public string DetalleEnfermedad { get; set; }
        public bool? Medicacion { get; set; }
        public bool? AdolescentePerdiodoGestacion { get; set; }
        public bool? AlgunaDiscapacidad { get; set; }
        public string TipoDiscapacidad { get; set; }
        public string PorcentajeDiscapacidad { get; set; }
        public string NumeroCarnet { get; set; }

        public virtual Persona IdPersonaNavigation { get; set; }
    }
}
