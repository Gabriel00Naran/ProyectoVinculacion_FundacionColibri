using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceFCMySql.Modelos
{
    public partial class Pgf
    {
        public int Idpgf { get; set; }
        public int? Idperonsa { get; set; }
        public int? Idfamiliarreferente { get; set; }
        public string Nombrefamiliar { get; set; }
        public int? Idprovincia { get; set; }
        public int? Idcanton { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public bool? NnaInsertosistemaeducativo { get; set; }
        public int? Idnivelacademico { get; set; }
        public string nombreunidad { get; set; }


        public virtual Canton IdcantonNavigation { get; set; }
        public virtual Familiarreferente IdfamiliarreferenteNavigation { get; set; }
        public virtual Nivelacademico IdnivelacademicoNavigation { get; set; }
        public virtual Persona IdperonsaNavigation { get; set; }
        public virtual Provincium IdprovinciaNavigation { get; set; }
    }
}
