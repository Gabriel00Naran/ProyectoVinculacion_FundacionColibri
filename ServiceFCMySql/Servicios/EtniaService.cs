using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebServiceFCMySql.IServicios;
using WebServiceFCMySql.Modelos;

namespace WebServiceFC.Servicios
{
    public class EtniaService : IEtniaService
    {
        ///<sumary>
        /// se instancia el contexto de la base de datos
        ///</sumary>
        ///<returns></returns>
        fundacioncolibriContext DB;
        public EtniaService(fundacioncolibriContext db)
        {
            DB = db;
        }

        ///<sumary>
        /// TRAE TODOS LAS PERSONAS REGISTRADAS EN LA FUNDACION EN LISTA
        ///</sumary>
        ///<returns></returns>
        public IEnumerable<Etnium> GetEtnia()
        {
            var Etnia = DB.Etnia.ToList();
            return Etnia;
        }

        /// <summary>  
        /// se añade o se registra Etnia
        /// </summary>  
        /// <param name="Etnia"></param>  
        /// <returns></returns>  
        public Etnium AddEtnia(Etnium Etnia)
        {
            if (Etnia != null)
            {

                DB.Etnia.Add(Etnia);
                DB.SaveChanges();
                return Etnia;
            }
            return null;
        }

        /// <summary>  
        /// para actualizar los datos  
        /// </summary>  
        /// <param name="Etnia"></param>  
        /// <returns></returns>  
        public Etnium UpdateEtnia(Etnium Etnia)
        {

            DB.Entry(Etnia).State = EntityState.Modified;
            DB.SaveChanges();
            return Etnia;
        }
        /// <summary>  
        /// elimina el registro 
        /// </summary>  
        /// <param name="idEtnia"></param>  
        /// <returns></returns>  
        public Etnium DeleteEtnia(int idEtnia)
        {
            var Etnia = DB.Etnia.FirstOrDefault(x => x.Idetnia == idEtnia);
            DB.Entry(Etnia).State = EntityState.Deleted;
            DB.SaveChanges();
            return Etnia;
        }

        /// <summary>  
        /// traer los detalles del registrado 
        /// </summary>  
        /// <param name="idEtnia"></param>  
        /// <returns></returns>  
        public Etnium GetEtniaById(int idEtnia)
        {
            var Etnia = DB.Etnia.FirstOrDefault(x => x.Idetnia == idEtnia);
            return Etnia;
        }


    }
}