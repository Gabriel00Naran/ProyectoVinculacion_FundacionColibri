using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebServiceFCMySql.IServicios;
using WebServiceFCMySql.Modelos;

namespace WebServiceFC.Servicios
{
    public class FamiliarReferenteService : IFamiliarReferenteService
    {
        ///<sumary>
        /// se instancia el contexto de la base de datos
        ///</sumary>
        ///<returns></returns>
        fundacioncolibriContext DB;
        public FamiliarReferenteService(fundacioncolibriContext db)
        {
            DB = db;
        }

        ///<sumary>
        /// TRAE TODOS LAS PERSONAS REGISTRADAS EN LA FUNDACION EN LISTA
        ///</sumary>
        ///<returns></returns>
        public IEnumerable<Familiarreferente> GetFamiliarReferente()
        {
            var familiarReferente = DB.Familiarreferentes.ToList();
            return familiarReferente;
        }

        /// <summary>  
        /// se añade o se registra familiarRefente
        /// </summary>  
        /// <param name="familiarRefente"></param>  
        /// <returns></returns>  
        public Familiarreferente AddFamiliarReferente(Familiarreferente familiarReferente)
        {
            if (familiarReferente != null)
            {

                DB.Familiarreferentes.Add(familiarReferente);
                DB.SaveChanges();
                return familiarReferente;
            }
            return null;
        }

        /// <summary>  
        /// para actualizar los datos  
        /// </summary>  
        /// <param name="familiarReferente"></param>  
        /// <returns></returns>  
        public Familiarreferente UpdateFamiliarReferente(Familiarreferente familiarReferente)
        {

            DB.Entry(familiarReferente).State = EntityState.Modified;
            DB.SaveChanges();
            return familiarReferente;
        }
        /// <summary>  
        /// elimina el registro 
        /// </summary>  
        /// <param name="idFamiliarRefente"></param>  
        /// <returns></returns>  
        public Familiarreferente DeleteFamiliarReferente(int idFamiliarReferente)
        {
            var familiarReferente = DB.Familiarreferentes.FirstOrDefault(x => x.Idfamiliarreferente == idFamiliarReferente);
            DB.Entry(familiarReferente).State = EntityState.Deleted;
            DB.SaveChanges();
            return familiarReferente;
        }

        /// <summary>  
        /// traer los detalles del registrado 
        /// </summary>  
        /// <param name="idFamiliarReferente"></param>  
        /// <returns></returns>  

        public Familiarreferente GetFamiliarReferenteById(int idFamiliarReferente)
        {
            var familiarRefente = DB.Familiarreferentes.FirstOrDefault(x => x.Idfamiliarreferente == idFamiliarReferente);
            return familiarRefente;
        }
    }
}