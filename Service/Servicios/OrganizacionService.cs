using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebServiceFC.Modelos;
using WebServiceFC.IServicios;

namespace WebServiceFC.Servicios
{
    public class OrganizacionService : IOrganizacionService
    {
        ///<sumary>
        /// se instancia el contexto de la base de datos
        ///</sumary>
        ///<returns></returns>
        FundacionColibriContext DB;
        public OrganizacionService(FundacionColibriContext db)
        {
            DB = db;
        }

        ///<sumary>
        /// TRAE TODOS LAS PERSONAS REGISTRADAS EN LA FUNDACION EN LISTA
        ///</sumary>
        ///<returns></returns>
        public IEnumerable<Organizacion> GetOrganizacion()
        {
            var organizacion = DB.Organizacions.ToList();
            return organizacion;
        }

        /// <summary>  
        /// se añade o se registra organizacion
        /// </summary>  
        /// <param name="organizacion"></param>  
        /// <returns></returns>  
        public Organizacion AddOrganizacion(Organizacion organizacion)
        {
            if (organizacion != null)
            {

                DB.Organizacions.Add(organizacion);
                DB.SaveChanges();
                return organizacion;
            }
            return null;
        }

        /// <summary>  
        /// para actualizar los datos  
        /// </summary>  
        /// <param name="organizacion"></param>  
        /// <returns></returns>  
        public Organizacion UpdateOrganizacion(Organizacion organizacion)
        {

            DB.Entry(organizacion).State = EntityState.Modified;
            DB.SaveChanges();
            return organizacion;
        }
        /// <summary>  
        /// elimina el registro 
        /// </summary>  
        /// <param name="idOrganizacion"></param>  
        /// <returns></returns>  
        public Organizacion DeleteOrganizacion(int idOrganizacion)
        {
            var organizacion = DB.Organizacions.FirstOrDefault(x => x.IdOrganizacion == idOrganizacion);
            DB.Entry(organizacion).State = EntityState.Deleted;
            DB.SaveChanges();
            return organizacion;
        }

        /// <summary>  
        /// traer los detalles del registrado 
        /// </summary>  
        /// <param name="idOrganizacion"></param>  
        /// <returns></returns>  
        public Organizacion GetOrganizacionById(int idOrganizacion)
        {
            var organizacion = DB.Organizacions.FirstOrDefault(x => x.IdOrganizacion == idOrganizacion);
            return organizacion;
        }


    }
}