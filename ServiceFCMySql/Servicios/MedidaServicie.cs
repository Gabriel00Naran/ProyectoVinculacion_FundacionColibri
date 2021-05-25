using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebServiceFCMySql.IServicios;
using WebServiceFCMySql.Modelos;

namespace WebServiceFC.Servicios
{
    public class MedidaService : IMedidaService
    {
        ///<sumary>
        /// se instancia el contexto de la base de datos
        ///</sumary>
        ///<returns></returns>
        fundacioncolibriContext DB;
        public MedidaService(fundacioncolibriContext db)
        {
            DB = db;
        }

        ///<sumary>
        /// TRAE TODOS LAS PERSONAS REGISTRADAS EN LA FUNDACION EN LISTA
        ///</sumary>
        ///<returns></returns>
        public IEnumerable<Medidum> GetMedida()
        {
            var medida = DB.Medida.ToList();
            return medida;
        }

        /// <summary>  
        /// se añade o se registra medida
        /// </summary>  
        /// <param name="medida"></param>  
        /// <returns></returns>  
        public Medidum AddMedida(Medidum medida)
        {
            if (medida != null)
            {

                DB.Medida.Add(medida);
                DB.SaveChanges();
                return medida;
            }
            return null;
        }

        /// <summary>  
        /// para actualizar los datos  
        /// </summary>  
        /// <param name="medida"></param>  
        /// <returns></returns>  
        public Medidum UpdateMedida(Medidum medida)
        {

            DB.Entry(medida).State = EntityState.Modified;
            DB.SaveChanges();
            return medida;
        }
        /// <summary>  
        /// elimina el registro 
        /// </summary>  
        /// <param name="idMedida"></param>  
        /// <returns></returns>  
        public Medidum DeleteMedida(int idMedida)
        {
            var medida = DB.Medida.FirstOrDefault(x => x.Idmedida == idMedida);
            DB.Entry(medida).State = EntityState.Deleted;
            DB.SaveChanges();
            return medida;
        }

        /// <summary>  
        /// traer los detalles del registrado 
        /// </summary>  
        /// <param name="idMedida"></param>  
        /// <returns></returns>  
        public Medidum GetMedidaById(int idMedida)
        {
            var medida = DB.Medida.FirstOrDefault(x => x.Idmedida == idMedida);
            return medida;
        }


    }
}