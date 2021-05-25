using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebServiceFCMySql.IServicios;
using WebServiceFCMySql.Modelos;

namespace WebServiceFC.Servicios
{
    public class NivelAcademicoService : INivelAcademicoService
    {
        ///<sumary>
        /// se instancia el contexto de la base de datos
        ///</sumary>
        ///<returns></returns>
        fundacioncolibriContext DB;
        public NivelAcademicoService(fundacioncolibriContext db)
        {
            DB = db;
        }

        ///<sumary>
        /// TRAE TODOS LAS PERSONAS REGISTRADAS EN LA FUNDACION EN LISTA
        ///</sumary>
        ///<returns></returns>
        public IEnumerable<Nivelacademico> GetNivelAcademico()
        {
            var nivelacademico = DB.Nivelacademicos.ToList();
            return nivelacademico;
        }

        /// <summary>  
        /// se añade o se registra canton
        /// </summary>  
        /// <param name="nivelAcademico"></param>  
        /// <returns></returns>  
        public Nivelacademico AddNivelAcademico(Nivelacademico nivelAcademico)
        {
            if (nivelAcademico != null)
            {

                DB.Nivelacademicos.Add(nivelAcademico);
                DB.SaveChanges();
                return nivelAcademico;
            }
            return null;
        }

        /// <summary>  
        /// para actualizar los datos  
        /// </summary>  
        /// <param name="nivelAcademico"></param>  
        /// <returns></returns>  
        public Nivelacademico UpdateNivelAcademico(Nivelacademico nivelAcademico)
        {

            DB.Entry(nivelAcademico).State = EntityState.Modified;
            DB.SaveChanges();
            return nivelAcademico;
        }
        /// <summary>  
        /// elimina el registro 
        /// </summary>  
        /// <param name="idNivelAcademico"></param>  
        /// <returns></returns>  
        public Nivelacademico DeleteNivelAcademico(int idNivelAcademico)
        {
            var nivelacademico = DB.Nivelacademicos.FirstOrDefault(x => x.Idnivelacademico == idNivelAcademico);
            DB.Entry(nivelacademico).State = EntityState.Deleted;
            DB.SaveChanges();
            return nivelacademico;
        }

        /// <summary>  
        /// traer los detalles del registrado 
        /// </summary>  
        /// <param name="idNivelAcademico"></param>  
        /// <returns></returns>  
        public Nivelacademico GetNivelAcademicoById(int idNivelAcademico)
        {
            var nivelacademico = DB.Nivelacademicos.FirstOrDefault(x => x.Idnivelacademico == idNivelAcademico);
            return nivelacademico;
        }


    }
}
