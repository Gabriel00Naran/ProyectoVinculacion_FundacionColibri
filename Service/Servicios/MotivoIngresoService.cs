using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebServiceFC.Modelos;
using WebServiceFC.IServicios;

namespace WebServiceFC.Servicios
{
    public class MotivoIngresoService : IMotivoIngresoService
    {
        ///<sumary>
        /// se instancia el contexto de la base de datos
        ///</sumary>
        ///<returns></returns>
        FundacionColibriContext DB;
        public MotivoIngresoService(FundacionColibriContext db)
        {
            DB = db;
        }

        ///<sumary>
        /// TRAE TODOS LAS PERSONAS REGISTRADAS EN LA FUNDACION EN LISTA
        ///</sumary>
        ///<returns></returns>
        public IEnumerable<MotivoIngreso> GetMotivoIngreso()
        {
            var motivoIngreso = DB.MotivoIngresos.ToList();
            return motivoIngreso;
        }

        /// <summary>  
        /// se añade o se registra motivoIngreso
        /// </summary>  
        /// <param name="motivoIngreso"></param>  
        /// <returns></returns>  
        public MotivoIngreso AddMotivoIngreso(MotivoIngreso motivoIngreso)
        {
            if (motivoIngreso != null)
            {

                DB.MotivoIngresos.Add(motivoIngreso);
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
        public MotivoIngreso UpdateMotivoIngreso(MotivoIngreso motivoIngreso)
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
        public MotivoIngreso DeleteMotivoIngreso(int idMotivoIngreso)
        {
            var motivoIngreso = DB.MotivoIngresos.FirstOrDefault(x => x.IdMotivoIngreso == idMotivoIngreso);
            DB.Entry(motivoIngreso).State = EntityState.Deleted;
            DB.SaveChanges();
            return motivoIngreso;
        }

        /// <summary>  
        /// traer los detalles del registrado 
        /// </summary>  
        /// <param name="idMotivoIngreso"></param>  
        /// <returns></returns>  
        public MotivoIngreso GetMotivoIngresoById(int idMotivoIngreso)
        {
            var motivoIngreso = DB.MotivoIngresos.FirstOrDefault(x => x.IdMotivoIngreso == idMotivoIngreso);
            return motivoIngreso;
        }


    }
}