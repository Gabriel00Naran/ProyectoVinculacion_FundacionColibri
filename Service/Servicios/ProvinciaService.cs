using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebServiceFC.Modelos;
using WebServiceFC.IServicios;

namespace WebServiceFC.Servicios
{
    public class ProvinciaService : IProvinciaService
    {
        ///<sumary>
        /// se instancia el contexto de la base de datos
        ///</sumary>
        ///<returns></returns>
        FundacionColibriContext DB;
        public ProvinciaService(FundacionColibriContext db)
        {
            DB = db;
        }

        ///<sumary>
        /// TRAE TODOS LAS PERSONAS REGISTRADAS EN LA FUNDACION EN LISTA
        ///</sumary>
        ///<returns></returns>
        public IEnumerable<Provincium> GetProvincia()
        {
            var provincia = DB.Provincia.ToList();
            return provincia;
        }

        /// <summary>  
        /// se añade o se registra provincia
        /// </summary>  
        /// <param name="provincia"></param>  
        /// <returns></returns>  
        public Provincium AddProvincia(Provincium provincia)
        {
            if (provincia != null)
            {

                DB.Provincia.Add(provincia);
                DB.SaveChanges();
                return provincia;
            }
            return null;
        }

        /// <summary>  
        /// para actualizar los datos  
        /// </summary>  
        /// <param name="provincia"></param>  
        /// <returns></returns>  
        public Provincium UpdateProvincia(Provincium provincia)
        {

            DB.Entry(provincia).State = EntityState.Modified;
            DB.SaveChanges();
            return provincia;
        }
        /// <summary>  
        /// elimina el registro 
        /// </summary>  
        /// <param name="idProvincia"></param>  
        /// <returns></returns>  
        public Provincium DeleteProvincia(int idProvincia)
        {
            var provincia = DB.Provincia.FirstOrDefault(x => x.IdProvincia == idProvincia);
            DB.Entry(provincia).State = EntityState.Deleted;
            DB.SaveChanges();
            return provincia;
        }

        /// <summary>  
        /// traer los detalles del registrado 
        /// </summary>  
        /// <param name="idProvincium"></param>  
        /// <returns></returns>  
        public Provincium GetProvinciaById(int idProvincia)
        {
            var provincia = DB.Provincia.FirstOrDefault(x => x.IdProvincia == idProvincia);
            return provincia;
        }


    }

  
}