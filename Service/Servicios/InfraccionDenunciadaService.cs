using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebServiceFC.Modelos;
using WebServiceFC.IServicios;

namespace WebServiceFC.Servicios
{
    public class InfraccionDenunciadaService : IInfraccionDenunciadaService
    {
        ///<sumary>
        /// se instancia el contexto de la base de datos
        ///</sumary>
        ///<returns></returns>
        FundacionColibriContext DB;
        public InfraccionDenunciadaService(FundacionColibriContext db)
        {
            DB = db;
        }

        ///<sumary>
        /// TRAE TODOS LAS PERSONAS REGISTRADAS EN LA FUNDACION EN LISTA
        ///</sumary>
        ///<returns></returns>
        public IEnumerable<InfraccionDenunciadum> GetInfraccionDenunciada()
        {
            var infraccionDenunciada = DB.InfraccionDenunciada.ToList();
            return infraccionDenunciada;
        }

        /// <summary>  
        /// se añade o se registra infraccionDenunciada
        /// </summary>  
        /// <param name="infraccionDenunciada"></param>  
        /// <returns></returns>  
        public InfraccionDenunciadum AddInfraccionDenunciada(InfraccionDenunciadum infraccionDenunciada)
        {
            if (infraccionDenunciada != null)
            {

                DB.InfraccionDenunciada.Add(infraccionDenunciada);
                DB.SaveChanges();
                return infraccionDenunciada;
            }
            return null;
        }

        /// <summary>  
        /// para actualizar los datos  
        /// </summary>  
        /// <param name="infraccionDenunciada"></param>  
        /// <returns></returns>  
        public InfraccionDenunciadum UpdateInfraccionDenunciada(InfraccionDenunciadum infraccionDenunciada)
        {

            DB.Entry(infraccionDenunciada).State = EntityState.Modified;
            DB.SaveChanges();
            return infraccionDenunciada;
        }
        /// <summary>  
        /// elimina el registro 
        /// </summary>  
        /// <param name="idInfraccionDenunciada"></param>  
        /// <returns></returns>  
        public InfraccionDenunciadum DeleteInfraccionDenunciada(int idInfraccionDenunciada)
        {
            var infraccionDenunciada = DB.InfraccionDenunciada.FirstOrDefault(x => x.IdInfraccionDenunciada == idInfraccionDenunciada);
            DB.Entry(infraccionDenunciada).State = EntityState.Deleted;
            DB.SaveChanges();
            return infraccionDenunciada;
        }

        /// <summary>  
        /// traer los detalles del registrado 
        /// </summary>  
        /// <param name="idInfraccionDenunciada"></param>  
        /// <returns></returns>  
        public InfraccionDenunciadum GetInfraccionDenunciadaById(int idInfraccionDenunciada)
        {
            var infraccionDenunciada = DB.InfraccionDenunciada.FirstOrDefault(x => x.IdInfraccionDenunciada == idInfraccionDenunciada);
            return infraccionDenunciada;
        }

      
    }
}