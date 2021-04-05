using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebServiceFC.Modelos;
using WebServiceFC.IServicios;

namespace WebServiceFC.Servicios
{
    public class HistorialCronologicoService : IHistorialCronologicoService
    {
        ///<sumary>
        /// se instancia el contexto de la base de datos
        ///</sumary>
        ///<returns></returns>
        FundacionColibriContext DB;
        public HistorialCronologicoService(FundacionColibriContext db)
        {
            DB = db;
        }

        ///<sumary>
        /// TRAE TODOS LAS PERSONAS REGISTRADAS EN LA FUNDACION EN LISTA
        ///</sumary>
        ///<returns></returns>
        public IEnumerable<HistorialCronologico> GetHistorialCronologico()
        {
            var historialCronologico = DB.HistorialCronologicos.ToList();
            return historialCronologico;
        }

        /// <summary>  
        /// se añade o se registra historialCronologico
        /// </summary>  
        /// <param name="historialCronologico"></param>  
        /// <returns></returns>  
        public HistorialCronologico AddHistorialCronologico(HistorialCronologico historialCronologico)
        {
            if (historialCronologico != null)
            {

                DB.HistorialCronologicos.Add(historialCronologico);
                DB.SaveChanges();
                return historialCronologico;
            }
            return null;
        }

        /// <summary>  
        /// para actualizar los datos  
        /// </summary>  
        /// <param name="historialCronologico"></param>  
        /// <returns></returns>  
        public HistorialCronologico UpdateHistorialCronologico(HistorialCronologico historialCronologico)
        {

            DB.Entry(historialCronologico).State = EntityState.Modified;
            DB.SaveChanges();
            return historialCronologico;
        }
        /// <summary>  
        /// elimina el registro 
        /// </summary>  
        /// <param name="idHistorialCronologico"></param>  
        /// <returns></returns>  
        public HistorialCronologico DeleteHistorialCronologico(Guid idHistorial)
        {
            var historialCronologico = DB.HistorialCronologicos.FirstOrDefault(x => x.IdHistorial == idHistorial);
            DB.Entry(historialCronologico).State = EntityState.Deleted;
            DB.SaveChanges();
            return historialCronologico;
        }

        /// <summary>  
        /// traer los detalles del registrado 
        /// </summary>  
        /// <param name="idHistorialCronologico"></param>  
        /// <returns></returns>  
        public HistorialCronologico GetHistorialCronologicoById(Guid idHistorial)
        {
            var historialCronologico = DB.HistorialCronologicos.FirstOrDefault(x => x.IdHistorial == idHistorial);
            return historialCronologico;
        }


    }
}