using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebServiceFCMySql.IServicios;
using WebServiceFCMySql.Modelos;

namespace WebServiceFC.Servicios
{
    public class DatosJudicialPenalService : IDatosJudicialPenalService
    {
        ///<sumary>
        /// se instancia el contexto de la base de datos
        ///</sumary>
        ///<returns></returns>
        fundacioncolibriContext DB;
        public DatosJudicialPenalService(fundacioncolibriContext db)
        {
            DB = db;
        }

        ///<sumary>
        /// TRAE TODOS LAS PERSONAS REGISTRADAS EN LA FUNDACION EN LISTA
        ///</sumary>
        ///<returns></returns>
        public IEnumerable<Datosjudicialpenal> GetDatosJudicialPenal()
        {
            var judicialPenal = DB.Datosjudicialpenals.ToList();
            return judicialPenal;
        }

        /// <summary>  
        /// se añade o se registra judicialPenal
        /// </summary>  
        /// <param name="judicialPenal"></param>  
        /// <returns></returns>  
        public Datosjudicialpenal AddDatosJudicialPenal(Datosjudicialpenal judicialPenal)
        {
            if (judicialPenal != null)
            {

                DB.Datosjudicialpenals.Add(judicialPenal);
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
        public Datosjudicialpenal UpdateDatosJudicialPenal(Datosjudicialpenal judicialPenal)
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
        public Datosjudicialpenal DeleteDatosJudicialPenal(int idJudicialPenal)
        {
            var judicialPenal = DB.Datosjudicialpenals.FirstOrDefault(x => x.Idjudicialpenal == idJudicialPenal);
            DB.Entry(judicialPenal).State = EntityState.Deleted;
            DB.SaveChanges();
            return judicialPenal;
        }

        /// <summary>  
        /// traer los detalles del registrado 
        /// </summary>  
        /// <param name="idJudicialPenal"></param>  
        /// <returns></returns>  
        public Datosjudicialpenal GetDatosJudicialPenalById(int idJudicialPenal)
        {
            var judicialPenal = DB.Datosjudicialpenals.FirstOrDefault(x => x.Idjudicialpenal == idJudicialPenal);
            return judicialPenal;
        }


        ///<summary>  
        /// traer los detalles del registrado con su id 
        /// </summary>  
        /// <param name="idpersona"></param>  
        /// <returns></returns>  
        public List<Datosjudicialpenal> GetDatosJudicialPenalByIdPersona(int idpersona)
        {
            var judicialPenal = DB.Datosjudicialpenals.Where(x => x.Idpersona == idpersona).ToList();
            return judicialPenal;
        }


    }
}