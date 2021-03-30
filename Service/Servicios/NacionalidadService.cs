using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebServiceFC.Modelos;
using WebServiceFC.IServicios;

namespace WebServiceFC.Servicios
{
    public class NacionalidadService : INacionalidadService
    {
        ///<sumary>
        /// se instancia el contexto de la base de datos
        ///</sumary>
        ///<returns></returns>
        FundacionColibriContext DB;
        public NacionalidadService(FundacionColibriContext db)
        {
            DB = db;
        }

        ///<sumary>
        /// TRAE TODOS LAS PERSONAS REGISTRADAS EN LA FUNDACION EN LISTA
        ///</sumary>
        ///<returns></returns>
        public IEnumerable<Nacionalidad> GetNacionalidad()
        {
            var nacionalidad = DB.Nacionalidads.ToList();
            return nacionalidad;
        }

        /// <summary>  
        /// se añade o se registra nacionalidad
        /// </summary>  
        /// <param name="nacionalidad"></param>  
        /// <returns></returns>  
        public Nacionalidad AddNacionalidad(Nacionalidad nacionalidad)
        {
            if (nacionalidad != null)
            {

                DB.Nacionalidads.Add(nacionalidad);
                DB.SaveChanges();
                return nacionalidad;
            }
            return null;
        }

        /// <summary>  
        /// para actualizar los datos  
        /// </summary>  
        /// <param name="nacionalidad"></param>  
        /// <returns></returns>  
        public Nacionalidad UpdateNacionalidad(Nacionalidad nacionalidad)
        {

            DB.Entry(nacionalidad).State = EntityState.Modified;
            DB.SaveChanges();
            return nacionalidad;
        }
        /// <summary>  
        /// elimina el registro 
        /// </summary>  
        /// <param name="idNacionalidad"></param>  
        /// <returns></returns>  
        public Nacionalidad DeleteNacionalidad(int idNacionalidad)
        {
            var nacionalidad = DB.Nacionalidads.FirstOrDefault(x => x.IdNacionalidad == idNacionalidad);
            DB.Entry(nacionalidad).State = EntityState.Deleted;
            DB.SaveChanges();
            return nacionalidad;
        }

        /// <summary>  
        /// traer los detalles del registrado 
        /// </summary>  
        /// <param name="idNacionalidad"></param>  
        /// <returns></returns>  
        public Nacionalidad GetNacionalidadById(int idNacionalidad)
        {
            var nacionalidad = DB.Nacionalidads.FirstOrDefault(x => x.IdNacionalidad == idNacionalidad);
            return nacionalidad;
        }


    }
}