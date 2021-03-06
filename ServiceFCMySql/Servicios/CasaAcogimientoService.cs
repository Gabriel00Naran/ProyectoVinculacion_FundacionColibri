using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebServiceFCMySql.IServicios;
using WebServiceFCMySql.Modelos;

namespace WebServiceFC.Servicios
{
    public class CasaAcogimientoService : ICasaAcogimientoService
    {
        ///<sumary>
        /// se instancia el contexto de la base de datos
        ///</sumary>
        ///<returns></returns>
        fundacioncolibriContext DB;
        public CasaAcogimientoService(fundacioncolibriContext db)
        {
            DB = db;
        }

        ///<sumary>
        /// TRAE TODOS LAS PERSONAS REGISTRADAS EN LA FUNDACION EN LISTA
        ///</sumary>
        ///<returns></returns>
        public IEnumerable<Casaacogimiento> GetCasaAcogimiento()
        {
            var casaAcogimiento = DB.Casaacogimientos.ToList();
            return casaAcogimiento;
        }

        /// <summary>  
        /// se añade o se registra casaAcogimiento
        /// </summary>  
        /// <param name="casaAcogimiento"></param>  
        /// <returns></returns>  
        public Casaacogimiento AddCasaAcogimiento(Casaacogimiento casaAcogimiento)
        {
            if (casaAcogimiento != null)
            {

                DB.Casaacogimientos.Add(casaAcogimiento);
                DB.SaveChanges();
                return casaAcogimiento;
            }
            return null;
        }

        /// <summary>  
        /// para actualizar los datos  
        /// </summary>  
        /// <param name="casaAcogimiento"></param>  
        /// <returns></returns>  
        public Casaacogimiento UpdateCasaAcogimiento(Casaacogimiento casaAcogimiento)
        {

            DB.Entry(casaAcogimiento).State = EntityState.Modified;
            DB.SaveChanges();
            return casaAcogimiento;
        }
        /// <summary>  
        /// elimina el registro 
        /// </summary>  
        /// <param name="idNombreCasaAnterior"></param>  
        /// <returns></returns>  
        public Casaacogimiento DeleteCasaAcogimiento(int idNombreCasaAnterior)
        {
            var casaAcogimiento = DB.Casaacogimientos.FirstOrDefault(x => x.Idnombrecasaanterior == idNombreCasaAnterior);
            DB.Entry(casaAcogimiento).State = EntityState.Deleted;
            DB.SaveChanges();
            return casaAcogimiento;
        }

        /// <summary>  
        /// traer los detalles del registrado 
        /// </summary>  
        /// <param name="idNombreCasaAnterior"></param>  
        /// <returns></returns>  
        public Casaacogimiento GetCasaAcogimientoById(int idNombreCasaAnterior)
        {
            var casaAcogimiento = DB.Casaacogimientos.FirstOrDefault(x => x.Idnombrecasaanterior == idNombreCasaAnterior);
            return casaAcogimiento;
        }


    }
}