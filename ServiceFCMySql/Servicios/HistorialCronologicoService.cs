using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebServiceFCMySql.IServicios;
using WebServiceFCMySql.Modelos;

namespace WebServiceFC.Servicios
{
    public class HistorialCronologicoService : IHistorialCronologicoService
    {
        ///<sumary>
        /// se instancia el contexto de la base de datos
        ///</sumary>
        ///<returns></returns>
        fundacioncolibriContext DB;
        public HistorialCronologicoService(fundacioncolibriContext db)
        {
            DB = db;
        }

        ///<sumary>
        /// TRAE TODOS LAS PERSONAS REGISTRADAS EN LA FUNDACION EN LISTA
        ///</sumary>
        ///<returns></returns>
        public IEnumerable<Historialcronologico> GetHistorialCronologico()
        {
            var historialCronologico = DB.Historialcronologicos.ToList();
            return historialCronologico;
        }

        /// <summary>  
        /// se añade o se registra historialCronologico
        /// </summary>  
        /// <param name="historialCronologico"></param>  
        /// <returns></returns>  
        public Historialcronologico AddHistorialCronologico(Historialcronologico historialCronologico)
        {
            if (historialCronologico != null)
            {

                DB.Historialcronologicos.Add(historialCronologico);
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
        public Historialcronologico UpdateHistorialCronologico(Historialcronologico historialCronologico)
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
        public Historialcronologico DeleteHistorialCronologico(int idHistorial)
        {
            var historialCronologico = DB.Historialcronologicos.FirstOrDefault(x => x.Idhistorial == idHistorial);
            DB.Entry(historialCronologico).State = EntityState.Deleted;
            DB.SaveChanges();
            return historialCronologico;
        }

        /// <summary>  
        /// traer los detalles del registrado 
        /// </summary>  
        /// <param name="idHistorialCronologico"></param>  
        /// <returns></returns>  
        public Historialcronologico GetHistorialCronologicoById(int idHistorial)
        {
            var historialCronologico = DB.Historialcronologicos.FirstOrDefault(x => x.Idhistorial == idHistorial);
            return historialCronologico;
        }

   /// <summary>  
        /// traer los detalles del registrado con su id 
        /// </summary>  
        /// <param name="idpersona"></param>  
        /// <returns></returns>  
        public List<Historialcronologico> GetHistorialCronologicoByIdPersona(int idpersona)
        {
            var historialCronologico = DB.Historialcronologicos.Where(x => x.Idpersona == idpersona).ToList();
            return historialCronologico;
        }

    }
}