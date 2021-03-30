using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebServiceFC.Modelos;
using WebServiceFC.IServicios;

namespace WebServiceFC.Servicios
{
    public class EstadoProcesalService : IEstadoProcesalService
    {
        ///<sumary>
        /// se instancia el contexto de la base de datos
        ///</sumary>
        ///<returns></returns>
        FundacionColibriContext DB;
        public EstadoProcesalService(FundacionColibriContext db)
        {
            DB = db;
        }

        ///<sumary>
        /// TRAE TODOS LAS PERSONAS REGISTRADAS EN LA FUNDACION EN LISTA
        ///</sumary>
        ///<returns></returns>
        public IEnumerable<EstadoProcesal> GetEstadoProcesal()
        {
            var estadoProcesal = DB.EstadoProcesals.ToList();
            return estadoProcesal;
        }

        /// <summary>  
        /// se añade o se registra estadoProcesal
        /// </summary>  
        /// <param name="estadoProcesal"></param>  
        /// <returns></returns>  
        public EstadoProcesal AddEstadoProcesal(EstadoProcesal estadoProcesal)
        {
            if (estadoProcesal != null)
            {

                DB.EstadoProcesals.Add(estadoProcesal);
                DB.SaveChanges();
                return estadoProcesal;
            }
            return null;
        }

        /// <summary>  
        /// para actualizar los datos  
        /// </summary>  
        /// <param name="estadoProcesal"></param>  
        /// <returns></returns>  
        public EstadoProcesal UpdateEstadoProcesal(EstadoProcesal estadoProcesal)
        {

            DB.Entry(estadoProcesal).State = EntityState.Modified;
            DB.SaveChanges();
            return estadoProcesal;
        }
        /// <summary>  
        /// elimina el registro 
        /// </summary>  
        /// <param name="idEstadoProcesal"></param>  
        /// <returns></returns>  
        public EstadoProcesal DeleteEstadoProcesal(int idEstadoProcesal)
        {
            var estadoProcesal = DB.EstadoProcesals.FirstOrDefault(x => x.IdEstadoProcesal == idEstadoProcesal);
            DB.Entry(estadoProcesal).State = EntityState.Deleted;
            DB.SaveChanges();
            return estadoProcesal;
        }

        /// <summary>  
        /// traer los detalles del registrado 
        /// </summary>  
        /// <param name="idEstadoProcesal"></param>  
        /// <returns></returns>  
        public EstadoProcesal GetEstadoProcesalById(int idEstadoProcesal)
        {
            var estadoProcesal = DB.EstadoProcesals.FirstOrDefault(x => x.IdEstadoProcesal == idEstadoProcesal);
            return estadoProcesal;
        }


    }
}