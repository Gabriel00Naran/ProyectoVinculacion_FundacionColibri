using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebServiceFC.Modelos;
using WebServiceFC.IServicios;

namespace WebServiceFC.Servicios
{
    public class CasaAcogimientoService : ICasaAcogimientoService
    {
        ///<sumary>
        /// se instancia el contexto de la base de datos
        ///</sumary>
        ///<returns></returns>
        FundacionColibriContext DB;
        public CasaAcogimientoService(FundacionColibriContext db)
        {
            DB = db;
        }

        ///<sumary>
        /// TRAE TODOS LAS PERSONAS REGISTRADAS EN LA FUNDACION EN LISTA
        ///</sumary>
        ///<returns></returns>
        public IEnumerable<CasaAcogimiento> GetCasaAcogimiento()
        {
            var casaAcogimiento = DB.CasaAcogimientos.ToList();
            return casaAcogimiento;
        }

        /// <summary>  
        /// se añade o se registra casaAcogimiento
        /// </summary>  
        /// <param name="casaAcogimiento"></param>  
        /// <returns></returns>  
        public CasaAcogimiento AddCasaAcogimiento(CasaAcogimiento casaAcogimiento)
        {
            if (casaAcogimiento != null)
            {

                DB.CasaAcogimientos.Add(casaAcogimiento);
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
        public CasaAcogimiento UpdateCasaAcogimiento(CasaAcogimiento casaAcogimiento)
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
        public CasaAcogimiento DeleteCasaAcogimiento(int idNombreCasaAnterior)
        {
            var casaAcogimiento = DB.CasaAcogimientos.FirstOrDefault(x => x.IdNombreCasaAnterior == idNombreCasaAnterior);
            DB.Entry(casaAcogimiento).State = EntityState.Deleted;
            DB.SaveChanges();
            return casaAcogimiento;
        }

        /// <summary>  
        /// traer los detalles del registrado 
        /// </summary>  
        /// <param name="idNombreCasaAnterior"></param>  
        /// <returns></returns>  
        public CasaAcogimiento GetCasaAcogimientoById(int idNombreCasaAnterior)
        {
            var casaAcogimiento = DB.CasaAcogimientos.FirstOrDefault(x => x.IdNombreCasaAnterior == idNombreCasaAnterior);
            return casaAcogimiento;
        }


    }
}