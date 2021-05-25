using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebServiceFCMySql.IServicios;
using WebServiceFCMySql.Modelos;

namespace WebServiceFC.Servicios
{
    public class MotivoIngresoService : IMotivoIngresoService
    {
        ///<sumary>
        /// se instancia el contexto de la base de datos
        ///</sumary>
        ///<returns></returns>
        fundacioncolibriContext DB;
        public MotivoIngresoService(fundacioncolibriContext db)
        {
            DB = db;
        }

        ///<sumary>
        /// TRAE TODOS LAS PERSONAS REGISTRADAS EN LA FUNDACION EN LISTA
        ///</sumary>
        ///<returns></returns>
        public IEnumerable<Motivoingreso> GetMotivoIngreso()
        {
            var motivoIngreso = DB.Motivoingresos.ToList();
            return motivoIngreso;
        }

        /// <summary>  
        /// se añade o se registra motivoIngreso
        /// </summary>  
        /// <param name="motivoIngreso"></param>  
        /// <returns></returns>  
        public Motivoingreso AddMotivoIngreso(Motivoingreso motivoIngreso)
        {
            if (motivoIngreso != null)
            {

                DB.Motivoingresos.Add(motivoIngreso);
                DB.SaveChanges();
                return motivoIngreso;
            }
            return null;
        }

        /// <summary>  
        /// para actualizar los datos  
        /// </summary>  
        /// <param name="motivoIngreso"></param>  
        /// <returns></returns>  
        public Motivoingreso UpdateMotivoIngreso(Motivoingreso motivoIngreso)
        {

            DB.Entry(motivoIngreso).State = EntityState.Modified;
            DB.SaveChanges();
            return motivoIngreso;
        }
        /// <summary>  
        /// elimina el registro 
        /// </summary>  
        /// <param name="idMotivoIngreso"></param>  
        /// <returns></returns>  
        public Motivoingreso DeleteMotivoIngreso(int idMotivoIngreso)
        {
            var motivoIngreso = DB.Motivoingresos.FirstOrDefault(x => x.Idmotivoingreso == idMotivoIngreso);
            DB.Entry(motivoIngreso).State = EntityState.Deleted;
            DB.SaveChanges();
            return motivoIngreso;
        }

        /// <summary>  
        /// traer los detalles del registrado 
        /// </summary>  
        /// <param name="idMotivoIngreso"></param>  
        /// <returns></returns>  
        public Motivoingreso GetMotivoIngresoById(int idMotivoIngreso)
        {
            var motivoIngreso = DB.Motivoingresos.FirstOrDefault(x => x.Idmotivoingreso == idMotivoIngreso);
            return motivoIngreso;
        }


    }
}