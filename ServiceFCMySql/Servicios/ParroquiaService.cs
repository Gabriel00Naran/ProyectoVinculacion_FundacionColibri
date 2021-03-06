using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebServiceFCMySql.IServicios;
using WebServiceFCMySql.Modelos;

namespace WebServiceFC.Servicios
{
    public class ParroquiaService : IParroquiaService
    {
        ///<sumary>
        /// se instancia el contexto de la base de datos
        ///</sumary>
        ///<returns></returns>
        fundacioncolibriContext DB;
        public ParroquiaService(fundacioncolibriContext db)
        {
            DB = db;
        }

        ///<sumary>
        /// TRAE TODOS LAS PERSONAS REGISTRADAS EN LA FUNDACION EN LISTA
        ///</sumary>
        ///<returns></returns>
        public IEnumerable<Parroquium> GetParroquia()
        {
            var parroquia = DB.Parroquia.ToList();
            return parroquia;
        }

        /// <summary>  
        /// se añade o se registra parroquia
        /// </summary>  
        /// <param name="parroquia"></param>  
        /// <returns></returns>  
        public Parroquium AddParroquia(Parroquium parroquia)
        {
            if (parroquia != null)
            {

                DB.Parroquia.Add(parroquia);
                DB.SaveChanges();
                return parroquia;
            }
            return null;
        }

        /// <summary>  
        /// para actualizar los datos  
        /// </summary>  
        /// <param name="parroquia"></param>  
        /// <returns></returns>  
        public Parroquium UpdateParroquia(Parroquium parroquia)
        {

            DB.Entry(parroquia).State = EntityState.Modified;
            DB.SaveChanges();
            return parroquia;
        }
        /// <summary>  
        /// elimina el registro 
        /// </summary>  
        /// <param name="idParroquia"></param>  
        /// <returns></returns>  
        public Parroquium DeleteParroquia(int idParroquia)
        {
            var parroquia = DB.Parroquia.FirstOrDefault(x => x.Idparroquia == idParroquia);
            DB.Entry(parroquia).State = EntityState.Deleted;
            DB.SaveChanges();
            return parroquia;
        }

        /// <summary>  
        /// traer los detalles del registrado 
        /// </summary>  
        /// <param name="idParroquia"></param>  
        /// <returns></returns>  
        public Parroquium GetParroquiaById(int idParroquia)
        {
            var parroquia = DB.Parroquia.FirstOrDefault(x => x.Idparroquia == idParroquia);
            return parroquia;
        }

        public List<Parroquium> GetParroquiaByIdCanton(int idcanton)
        {
            var parroquia = DB.Parroquia.Where(x => x.Idcanton == idcanton).ToList();
            return parroquia;
        }



    }
}