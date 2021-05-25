using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebServiceFCMySql.IServicios;
using WebServiceFCMySql.Modelos;

namespace WebServiceFCMySql.Servicios
{
    public class EstadoProcesalService : IEstadoProcesalService
    {
        ///<sumary>
        /// se instancia el contexto de la base de datos
        ///</sumary>
        ///<returns></returns>
        fundacioncolibriContext DB;
        public EstadoProcesalService(fundacioncolibriContext db)
        {
            DB = db;
        }

        ///<sumary>
        /// TRAE TODOS LAS PERSONAS REGISTRADAS EN LA FUNDACION EN LISTA
        ///</sumary>
        ///<returns></returns>
        public IEnumerable<Estadoprocesal> GetEstadoProcesal()
        {
            var estadoProcesal = DB.Estadoprocesals.ToList();
            return estadoProcesal;
        }

        /// <summary>  
        /// se añade o se registra estadoProcesal
        /// </summary>  
        /// <param name="estadoProcesal"></param>  
        /// <returns></returns>  
        public Estadoprocesal AddEstadoProcesal(Estadoprocesal estadoProcesal)
        {
            if (estadoProcesal != null)
            {

                DB.Estadoprocesals.Add(estadoProcesal);
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
        public Estadoprocesal UpdateEstadoProcesal(Estadoprocesal estadoProcesal)
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
        public Estadoprocesal DeleteEstadoProcesal(int idEstadoProcesal)
        {
            var estadoProcesal = DB.Estadoprocesals.FirstOrDefault(x => x.Idestadoprocesal == idEstadoProcesal);
            DB.Entry(estadoProcesal).State = EntityState.Deleted;
            DB.SaveChanges();
            return estadoProcesal;
        }

        /// <summary>  
        /// traer los detalles del registrado 
        /// </summary>  
        /// <param name="idEstadoProcesal"></param>  
        /// <returns></returns>  
        public Estadoprocesal GetEstadoProcesalById(int idEstadoProcesal)
        {
            var estadoProcesal = DB.Estadoprocesals.FirstOrDefault(x => x.Idestadoprocesal == idEstadoProcesal);
            return estadoProcesal;
        }


    }
}