using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebServiceFC.Modelos;
using WebServiceFC.IServicios;

namespace WebServiceFC.Servicios
{
    public class DatosSaludService : IDatosSaludService
    {
        ///<sumary>
        /// se instancia el contexto de la base de datos
        ///</sumary>
        ///<returns></returns>
        FundacionColibriContext DB;
        public DatosSaludService(FundacionColibriContext db)
        {
            DB = db;
        }

        ///<sumary>
        /// TRAE TODOS LAS PERSONAS REGISTRADAS EN LA FUNDACION EN LISTA
        ///</sumary>
        ///<returns></returns>
        public IEnumerable<DatosSalud> GetDatosSalud()
        {
            var datosSalud = DB.DatosSaluds.ToList();
            return datosSalud;
        }

        /// <summary>  
        /// se añade o se registra datosSalud
        /// </summary>  
        /// <param name="datosSalud"></param>  
        /// <returns></returns>  
        public DatosSalud AddDatosSalud(DatosSalud datosSalud)
        {
            if (datosSalud != null)
            {

                DB.DatosSaluds.Add(datosSalud);
                DB.SaveChanges();
                return datosSalud;
            }
            return null;
        }

        /// <summary>  
        /// para actualizar los datos  
        /// </summary>  
        /// <param name="datosSalud"></param>  
        /// <returns></returns>  
        public DatosSalud UpdateDatosSalud(DatosSalud datosSalud)
        {

            DB.Entry(datosSalud).State = EntityState.Modified;
            DB.SaveChanges();
            return datosSalud;
        }
        /// <summary>  
        /// elimina el registro 
        /// </summary>  
        /// <param name="idDatosSalud"></param>  
        /// <returns></returns>  
        public DatosSalud DeleteDatosSalud(Guid idDatosSalud)
        {
            var datosSalud = DB.DatosSaluds.FirstOrDefault(x => x.IdDatosSalud == idDatosSalud);
            DB.Entry(datosSalud).State = EntityState.Deleted;
            DB.SaveChanges();
            return datosSalud;
        }

        /// <summary>  
        /// traer los detalles del registrado 
        /// </summary>  
        /// <param name="idDatosSalud"></param>  
        /// <returns></returns>  
        public DatosSalud GetDatosSaludById(Guid idDatosSalud)
        {
            var datosSalud = DB.DatosSaluds.FirstOrDefault(x => x.IdDatosSalud == idDatosSalud);
            return datosSalud;
        }


    }
}