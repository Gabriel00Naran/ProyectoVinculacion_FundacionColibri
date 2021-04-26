using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebServiceFCMySql.IServicios;
using WebServiceFCMySql.Modelos;

namespace WebServiceFC.Servicios
{
    public class PgfService : IPgfService
    {
        ///<sumary>
        /// se instancia el contexto de la base de datos
        ///</sumary>
        ///<returns></returns>
        fundacioncolibriContext DB;
        public PgfService(fundacioncolibriContext db)
        {
            DB = db;
        }

        ///<sumary>
        /// TRAE TODOS LAS PERSONAS REGISTRADAS EN LA FUNDACION EN LISTA
        ///</sumary>
        ///<returns></returns>
        public IEnumerable<Pgf> GetPgf()
        {
            var pgf = DB.Pgfs.ToList();
            return pgf;
        }

        /// <summary>  
        /// se añade o se registra pgf
        /// </summary>  
        /// <param name="pgf"></param>  
        /// <returns></returns>  
        public Pgf AddPgf(Pgf pgf)
        {
            if (pgf != null)
            {

                DB.Pgfs.Add(pgf);
                DB.SaveChanges();
                return pgf;
            }
            return null;
        }

        /// <summary>  
        /// para actualizar los datos  
        /// </summary>  
        /// <param name="pgf"></param>  
        /// <returns></returns>  
        public Pgf UpdatePgf(Pgf pgf)
        {

            DB.Entry(pgf).State = EntityState.Modified;
            DB.SaveChanges();
            return pgf;
        }
        /// <summary>  
        /// elimina el registro 
        /// </summary>  
        /// <param name="idPgf"></param>  
        /// <returns></returns>  
        public Pgf DeletePgf(int idPgf)
        {
            var pgf = DB.Pgfs.FirstOrDefault(x => x.Idpgf == idPgf);
            DB.Entry(pgf).State = EntityState.Deleted;
            DB.SaveChanges();
            return pgf;
        }

        /// <summary>  
        /// traer los detalles del registrado 
        /// </summary>  
        /// <param name="idPgf"></param>  
        /// <returns></returns>  
        public Pgf GetPgfById(int idPgf)
        {
            var pgf = DB.Pgfs.FirstOrDefault(x => x.Idpgf == idPgf);
            return pgf;
        }

        ///<summary>  
        /// traer los detalles del registrado con su id 
        /// </summary>  
        /// <param name="idpersona"></param>  
        /// <returns></returns>  
        public List<Pgf> GetPgfByIdPersona(int idpersona)
        {
            var pgf = DB.Pgfs.Where(x => x.Idperonsa == idpersona).ToList();
            return pgf;
        }
    }
}