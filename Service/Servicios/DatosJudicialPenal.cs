using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebServiceFC.Modelos;
using WebServiceFC.IServicios;

namespace WebServiceFC.Servicios
{
    public class DatosJudicialPenalService : IDatosJudicialPenalService
    {
        ///<sumary>
        /// se instancia el contexto de la base de datos
        ///</sumary>
        ///<returns></returns>
        FundacionColibriContext DB;
        public DatosJudicialPenalService(FundacionColibriContext db)
        {
            DB = db;
        }

        ///<sumary>
        /// TRAE TODOS LAS PERSONAS REGISTRADAS EN LA FUNDACION EN LISTA
        ///</sumary>
        ///<returns></returns>
        public IEnumerable<DatosJudicialPenal> GetDatosJudicialPenal()
        {
            var judicialPenal = DB.DatosJudicialPenals.ToList();
            return judicialPenal;
        }

        /// <summary>  
        /// se añade o se registra judicialPenal
        /// </summary>  
        /// <param name="judicialPenal"></param>  
        /// <returns></returns>  
        public DatosJudicialPenal AddDatosJudicialPenal(DatosJudicialPenal judicialPenal)
        {
            if (judicialPenal != null)
            {

                DB.DatosJudicialPenals.Add(judicialPenal);
                DB.SaveChanges();
                return judicialPenal;
            }
            return null;
        }

        /// <summary>  
        /// para actualizar los datos  
        /// </summary>  
        /// <param name="judicialPenal"></param>  
        /// <returns></returns>  
        public DatosJudicialPenal UpdateDatosJudicialPenal(DatosJudicialPenal judicialPenal)
        {

            DB.Entry(judicialPenal).State = EntityState.Modified;
            DB.SaveChanges();
            return judicialPenal;
        }
        /// <summary>  
        /// elimina el registro 
        /// </summary>  
        /// <param name="idJudicialPenal"></param>  
        /// <returns></returns>  
        public DatosJudicialPenal DeleteDatosJudicialPenal(Guid idJudicialPenal)
        {
            var judicialPenal = DB.DatosJudicialPenals.FirstOrDefault(x => x.IdJudicialPenal == idJudicialPenal);
            DB.Entry(judicialPenal).State = EntityState.Deleted;
            DB.SaveChanges();
            return judicialPenal;
        }

        /// <summary>  
        /// traer los detalles del registrado 
        /// </summary>  
        /// <param name="idJudicialPenal"></param>  
        /// <returns></returns>  
        public DatosJudicialPenal GetDatosJudicialPenalById(Guid idJudicialPenal)
        {
            var judicialPenal = DB.DatosJudicialPenals.FirstOrDefault(x => x.IdJudicialPenal == idJudicialPenal);
            return judicialPenal;
        }


    }
}