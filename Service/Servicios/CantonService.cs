using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebServiceFC.Modelos;
using WebServiceFC.IServicios;

namespace WebServiceFC.Servicios
{
    public class CantonService : ICantonService
    {
        ///<sumary>
        /// se instancia el contexto de la base de datos
        ///</sumary>
        ///<returns></returns>
        FundacionColibriContext DB;
        public CantonService(FundacionColibriContext db)
        {
            DB = db;
        }

        ///<sumary>
        /// TRAE TODOS LAS PERSONAS REGISTRADAS EN LA FUNDACION EN LISTA
        ///</sumary>
        ///<returns></returns>
        public IEnumerable<Canton> GetCanton()
        {
            var canton = DB.Cantons.ToList();
            return canton;
        }

        /// <summary>  
        /// se añade o se registra canton
        /// </summary>  
        /// <param name="canton"></param>  
        /// <returns></returns>  
        public Canton AddCanton(Canton canton)
        {
            if (canton != null)
            {

                DB.Cantons.Add(canton);
                DB.SaveChanges();
                return canton;
            }
            return null;
        }

        /// <summary>  
        /// para actualizar los datos  
        /// </summary>  
        /// <param name="canton"></param>  
        /// <returns></returns>  
        public Canton UpdateCanton(Canton canton)
        {

            DB.Entry(canton).State = EntityState.Modified;
            DB.SaveChanges();
            return canton;
        }
        /// <summary>  
        /// elimina el registro 
        /// </summary>  
        /// <param name="idCanton"></param>  
        /// <returns></returns>  
        public Canton DeleteCanton(int idCanton)
        {
            var canton = DB.Cantons.FirstOrDefault(x => x.IdCanton == idCanton);
            DB.Entry(canton).State = EntityState.Deleted;
            DB.SaveChanges();
            return canton;
        }

        /// <summary>  
        /// traer los detalles del registrado 
        /// </summary>  
        /// <param name="idCanton"></param>  
        /// <returns></returns>  
        public Canton GetCantonById(int idCanton)
        {
            var canton = DB.Cantons.FirstOrDefault(x => x.IdCanton == idCanton);
            return canton;
        }


    }
}
