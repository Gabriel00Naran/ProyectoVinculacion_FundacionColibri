using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebServiceFCMySql.IServicios;
using WebServiceFCMySql.Modelos;

namespace WebServiceFC.Servicios
{
    public class DatosSaludService : IDatosSaludService
    {
        ///<sumary>
        /// se instancia el contexto de la base de datos
        ///</sumary>
        ///<returns></returns>
        fundacioncolibriContext DB;
        public DatosSaludService(fundacioncolibriContext db)
        {
            DB = db;
        }

        ///<sumary>
        /// TRAE TODOS LAS PERSONAS REGISTRADAS EN LA FUNDACION EN LISTA
        ///</sumary>
        ///<returns></returns>
        public IEnumerable<Datossalud> GetDatosSalud()
        {
            var datosSalud = DB.Datossaluds.ToList();
            return datosSalud;
        }

        /// <summary>  
        /// se añade o se registra datosSalud
        /// </summary>  
        /// <param name="datosSalud"></param>  
        /// <returns></returns>  
        public Datossalud AddDatosSalud(Datossalud datosSalud)
        {
            if (datosSalud != null)
            {

                DB.Datossaluds.Add(datosSalud);
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
        public Datossalud UpdateDatosSalud(Datossalud datosSalud)
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
        public Datossalud DeleteDatosSalud(int idDatosSalud)
        {
            var datosSalud = DB.Datossaluds.FirstOrDefault(x => x.Iddatossalud == idDatosSalud);
            DB.Entry(datosSalud).State = EntityState.Deleted;
            DB.SaveChanges();
            return datosSalud;
        }

        /// <summary>  
        /// traer los detalles del registrado 
        /// </summary>  
        /// <param name="idDatosSalud"></param>  
        /// <returns></returns>  
        public Datossalud GetDatosSaludById(int idDatosSalud)
        {
            var datosSalud = DB.Datossaluds.FirstOrDefault(x => x.Iddatossalud == idDatosSalud);
            return datosSalud;
        }


         ///<summary>  
        /// traer los detalles del registrado con su id 
        /// </summary>  
        /// <param name="idpersona"></param>  
        /// <returns></returns>  
        public List<Datossalud> GetDatosSaludByIdPersona(int idpersona)
        {
            var datosSalud = DB.Datossaluds.Where(x => x.Idpersona == idpersona).ToList();
            return datosSalud;
        }

    }
}