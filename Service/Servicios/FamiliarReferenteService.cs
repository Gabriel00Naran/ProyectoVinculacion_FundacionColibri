using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebServiceFC.Modelos;
using WebServiceFC.IServicios;

namespace WebServiceFC.Servicios
{
    public class FamiliarReferenteService : IFamiliarReferenteService
    {
        ///<sumary>
        /// se instancia el contexto de la base de datos
        ///</sumary>
        ///<returns></returns>
        FundacionColibriContext DB;
        public FamiliarReferenteService(FundacionColibriContext db)
        {
            DB = db;
        }

        ///<sumary>
        /// TRAE TODOS LAS PERSONAS REGISTRADAS EN LA FUNDACION EN LISTA
        ///</sumary>
        ///<returns></returns>
        public IEnumerable<FamiliarReferente> GetFamiliarReferente()
        {
            var familiarReferente = DB.FamiliarReferentes.ToList();
            return familiarReferente;
        }

        /// <summary>  
        /// se añade o se registra familiarRefente
        /// </summary>  
        /// <param name="familiarRefente"></param>  
        /// <returns></returns>  
        public FamiliarReferente AddFamiliarReferente(FamiliarReferente familiarReferente)
        {
            if (familiarReferente != null)
            {

                DB.FamiliarReferentes.Add(familiarReferente);
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
        public FamiliarReferente UpdateFamiliarReferente(FamiliarReferente familiarReferente)
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
        public FamiliarReferente DeleteFamiliarReferente(int idFamiliarReferente)
        {
            var familiarReferente = DB.FamiliarReferentes.FirstOrDefault(x => x.IdFamiliarReferente == idFamiliarReferente);
            DB.Entry(familiarReferente).State = EntityState.Deleted;
            DB.SaveChanges();
            return familiarReferente;
        }

        /// <summary>  
        /// traer los detalles del registrado 
        /// </summary>  
        /// <param name="idFamiliarReferente"></param>  
        /// <returns></returns>  

        public FamiliarReferente GetFamiliarReferenteById(int idFamiliarReferente)
        {
            var familiarRefente = DB.FamiliarReferentes.FirstOrDefault(x => x.IdFamiliarReferente == idFamiliarReferente);
            return familiarRefente;
        }
    }
}