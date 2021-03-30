using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebServiceFC.Modelos;
using WebServiceFC.IServicios;

namespace WebServiceFC.Servicios
{
    public class NudosCriticoService : INudosCriticoService
    {
        ///<sumary>
        /// se instancia el contexto de la base de datos
        ///</sumary>
        ///<returns></returns>
        FundacionColibriContext DB;
        public NudosCriticoService(FundacionColibriContext db)
        {
            DB = db;
        }

        ///<sumary>
        /// TRAE TODOS LAS PERSONAS REGISTRADAS EN LA FUNDACION EN LISTA
        ///</sumary>
        ///<returns></returns>
        public IEnumerable<NudosCritico> GetNudosCritico()
        {
            var nudosCriticos = DB.NudosCriticos.ToList();
            return nudosCriticos;
        }

        /// <summary>  
        /// se añade o se registra nudosCriticos
        /// </summary>  
        /// <param name="nudosCriticos"></param>  
        /// <returns></returns>  
        public NudosCritico AddNudosCritico(NudosCritico nudosCriticos)
        {
            if (nudosCriticos != null)
            {

                DB.NudosCriticos.Add(nudosCriticos);
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
        public NudosCritico UpdateNudosCritico(NudosCritico nudosCriticos)
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
        public NudosCritico DeleteNudosCritico(int idNudosCriticos)
        {
            var nudosCriticos = DB.NudosCriticos.FirstOrDefault(x => x.IdNudosCriticos == idNudosCriticos);
            DB.Entry(nudosCriticos).State = EntityState.Deleted;
            DB.SaveChanges();
            return nudosCriticos;
        }

        /// <summary>  
        /// traer los detalles del registrado 
        /// </summary>  
        /// <param name="idNudosCritico"></param>  
        /// <returns></returns>  
        public NudosCritico GetNudosCriticoById(int idNudosCriticos)
        {
            var nudosCriticos = DB.NudosCriticos.FirstOrDefault(x => x.IdNudosCriticos == idNudosCriticos);
            return nudosCriticos;
        }


    }
}