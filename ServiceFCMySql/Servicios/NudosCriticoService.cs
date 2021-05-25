using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebServiceFCMySql.IServicios;
using WebServiceFCMySql.Modelos;

namespace WebServiceFC.Servicios
{
    public class NudosCriticoService : INudosCriticoService
    {
        ///<sumary>
        /// se instancia el contexto de la base de datos
        ///</sumary>
        ///<returns></returns>
        fundacioncolibriContext DB;
        public NudosCriticoService(fundacioncolibriContext db)
        {
            DB = db;
        }

        ///<sumary>
        /// TRAE TODOS LAS PERSONAS REGISTRADAS EN LA FUNDACION EN LISTA
        ///</sumary>
        ///<returns></returns>
        public IEnumerable<Nudoscritico> GetNudosCritico()
        {
            var nudosCriticos = DB.Nudoscriticos.ToList();
            return nudosCriticos;
        }

        /// <summary>  
        /// se añade o se registra nudosCriticos
        /// </summary>  
        /// <param name="nudosCriticos"></param>  
        /// <returns></returns>  
        public Nudoscritico AddNudosCritico(Nudoscritico nudosCriticos)
        {
            if (nudosCriticos != null)
            {

                DB.Nudoscriticos.Add(nudosCriticos);
                DB.SaveChanges();
                return nudosCriticos;
            }
            return null;
        }

        /// <summary>  
        /// para actualizar los datos  
        /// </summary>  
        /// <param name="nudosCriticos"></param>  
        /// <returns></returns>  
        public Nudoscritico UpdateNudosCritico(Nudoscritico nudosCriticos)
        {

            DB.Entry(nudosCriticos).State = EntityState.Modified;
            DB.SaveChanges();
            return nudosCriticos;
        }
        /// <summary>  
        /// elimina el registro 
        /// </summary>  
        /// <param name="idNudosCritico"></param>  
        /// <returns></returns>  
        public Nudoscritico DeleteNudosCritico(int idNudosCriticos)
        {
            var nudosCriticos = DB.Nudoscriticos.FirstOrDefault(x => x.Idnudoscriticos == idNudosCriticos);
            DB.Entry(nudosCriticos).State = EntityState.Deleted;
            DB.SaveChanges();
            return nudosCriticos;
        }

        /// <summary>  
        /// traer los detalles del registrado 
        /// </summary>  
        /// <param name="idNudosCritico"></param>  
        /// <returns></returns>  
        public Nudoscritico GetNudosCriticoById(int idNudosCriticos)
        {
            var nudosCriticos = DB.Nudoscriticos.FirstOrDefault(x => x.Idnudoscriticos == idNudosCriticos);
            return nudosCriticos;
        }


    }
}