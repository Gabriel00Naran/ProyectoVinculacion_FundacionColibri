using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebServiceFC.Modelos;
using WebServiceFC.IServicios;

namespace WebServiceFC.Servicios
{
    public class GeneroService : IGeneroService
    {
        ///<sumary>
        /// se instancia el contexto de la base de datos
        ///</sumary>
        ///<returns></returns>
        FundacionColibriContext DB;
        public GeneroService(FundacionColibriContext db)
        {
            DB = db;
        }

        ///<sumary>
        /// TRAE TODOS LAS PERSONAS REGISTRADAS EN LA FUNDACION EN LISTA
        ///</sumary>
        ///<returns></returns>
        public IEnumerable<Genero> GetGenero()
        {
            var genero = DB.Generos.ToList();
            return genero;
        }

        /// <summary>  
        /// se añade o se registra genero
        /// </summary>  
        /// <param name="genero"></param>  
        /// <returns></returns>  
        public Genero AddGenero(Genero genero)
        {
            if (genero != null)
            {

                DB.Generos.Add(genero);
                DB.SaveChanges();
                return genero;
            }
            return null;
        }

        /// <summary>  
        /// para actualizar los datos  
        /// </summary>  
        /// <param name="genero"></param>  
        /// <returns></returns>  
        public Genero UpdateGenero(Genero genero)
        {

            DB.Entry(genero).State = EntityState.Modified;
            DB.SaveChanges();
            return genero;
        }
        /// <summary>  
        /// elimina el registro 
        /// </summary>  
        /// <param name="idGenero"></param>  
        /// <returns></returns>  
        public Genero DeleteGenero(int idGenero)
        {
            var genero = DB.Generos.FirstOrDefault(x => x.IdGenero == idGenero);
            DB.Entry(genero).State = EntityState.Deleted;
            DB.SaveChanges();
            return genero;
        }

        /// <summary>  
        /// traer los detalles del registrado 
        /// </summary>  
        /// <param name="idGenero"></param>  
        /// <returns></returns>  
        public Genero GetGeneroById(int idGenero)
        {
            var genero = DB.Generos.FirstOrDefault(x => x.IdGenero == idGenero);
            return genero;
        }


    }
}
