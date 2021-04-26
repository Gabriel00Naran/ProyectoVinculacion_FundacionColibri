using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebServiceFCMySql.IServicios;
using WebServiceFCMySql.Modelos;

namespace WebServiceFC.Servicios
{
    public class InfraccionDenunciadaService : IInfraccionDenunciadaService
    {
        ///<sumary>
        /// se instancia el contexto de la base de datos
        ///</sumary>
        ///<returns></returns>
        fundacioncolibriContext DB;
        public InfraccionDenunciadaService(fundacioncolibriContext db)
        {
            DB = db;
        }

        ///<sumary>
        /// TRAE TODOS LAS PERSONAS REGISTRADAS EN LA FUNDACION EN LISTA
        ///</sumary>
        ///<returns></returns>
        public IEnumerable<Infracciondenunciadum> GetInfraccionDenunciada()
        {
            var infraccionDenunciada = DB.Infracciondenunciada.ToList();
            return infraccionDenunciada;
        }

        /// <summary>  
        /// se añade o se registra infraccionDenunciada
        /// </summary>  
        /// <param name="infraccionDenunciada"></param>  
        /// <returns></returns>  
        public Infracciondenunciadum AddInfraccionDenunciada(Infracciondenunciadum infraccionDenunciada)
        {
            if (infraccionDenunciada != null)
            {

                DB.Infracciondenunciada.Add(infraccionDenunciada);
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
        public Infracciondenunciadum UpdateInfraccionDenunciada(Infracciondenunciadum infraccionDenunciada)
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
        public Infracciondenunciadum DeleteInfraccionDenunciada(int idInfraccionDenunciada)
        {
            var infraccionDenunciada = DB.Infracciondenunciada.FirstOrDefault(x => x.Idinfracciondenunciada == idInfraccionDenunciada);
            DB.Entry(infraccionDenunciada).State = EntityState.Deleted;
            DB.SaveChanges();
            return infraccionDenunciada;
        }

        /// <summary>  
        /// traer los detalles del registrado 
        /// </summary>  
        /// <param name="idInfraccionDenunciada"></param>  
        /// <returns></returns>  
        public Infracciondenunciadum GetInfraccionDenunciadaById(int idInfraccionDenunciada)
        {
            var infraccionDenunciada = DB.Infracciondenunciada.FirstOrDefault(x => x.Idinfracciondenunciada == idInfraccionDenunciada);
            return infraccionDenunciada;
        }


    }
}