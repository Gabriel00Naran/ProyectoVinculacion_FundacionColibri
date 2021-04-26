using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebServiceFCMySql.IServicios;
using WebServiceFCMySql.Modelos;

namespace WebServiceFC.Servicios
{
    public class ModalidadService : IModalidadService
    {
        ///<sumary>
        /// se instancia el contexto de la base de datos
        ///</sumary>
        ///<returns></returns>
        fundacioncolibriContext DB;
        public ModalidadService(fundacioncolibriContext db)
        {
            DB = db;
        }

        ///<sumary>
        /// TRAE TODOS LAS PERSONAS REGISTRADAS EN LA FUNDACION EN LISTA
        ///</sumary>
        ///<returns></returns>
        public IEnumerable<Modalidad> GetModalidad()
        {
            var modalidad = DB.Modalidads.ToList();
            return modalidad;
        }

        /// <summary>  
        /// se añade o se registra modalidad
        /// </summary>  
        /// <param name="modalidad"></param>  
        /// <returns></returns>  
        public Modalidad AddModalidad(Modalidad modalidad)
        {
            if (modalidad != null)
            {

                DB.Modalidads.Add(modalidad);
                DB.SaveChanges();
                return modalidad;
            }
            return null;
        }

        /// <summary>  
        /// para actualizar los datos  
        /// </summary>  
        /// <param name="modalidad"></param>  
        /// <returns></returns>  
        public Modalidad UpdateModalidad(Modalidad modalidad)
        {

            DB.Entry(modalidad).State = EntityState.Modified;
            DB.SaveChanges();
            return modalidad;
        }
        /// <summary>  
        /// elimina el registro 
        /// </summary>  
        /// <param name="idModalidad"></param>  
        /// <returns></returns>  
        public Modalidad DeleteModalidad(int idModalidad)
        {
            var modalidad = DB.Modalidads.FirstOrDefault(x => x.Idmodalidad == idModalidad);
            DB.Entry(modalidad).State = EntityState.Deleted;
            DB.SaveChanges();
            return modalidad;
        }

        /// <summary>  
        /// traer los detalles del registrado 
        /// </summary>  
        /// <param name="idModalidad"></param>  
        /// <returns></returns>  
        public Modalidad GetModalidadById(int idModalidad)
        {
            var modalidad = DB.Modalidads.FirstOrDefault(x => x.Idmodalidad == idModalidad);
            return modalidad;
        }


    }
}