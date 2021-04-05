using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using WebServiceFC.Modelos;
using WebServiceFC.IServicios;

namespace WebServiceFC.Servicios
{
    public class PersonaService : IPersonaService
    {

        ///<sumary>
        /// aqui se calcula la edad. dependiendo de la fecha actual
        ///</sumary>
        ///<returns></returns>
         void edadCalcular(Persona persona)
        {
            
        
            DateTime fechaNacimiento = (DateTime)persona.FechaNacimiento;
            int edad = DateTime.Today.Year - fechaNacimiento.Year;
            if (DateTime.Today < fechaNacimiento.AddYears(edad))
                --edad;
            persona.Edad = edad.ToString();


        }
        ///<sumary>
        /// se instancia el contexto de la base de datos
        ///</sumary>
        ///<returns></returns>
        FundacionColibriContext DB;
        public PersonaService(FundacionColibriContext db)
        {
            DB = db;
        }

        ///<sumary>
        /// TRAE TODOS LAS PERSONAS REGISTRADAS EN LA FUNDACION EN LISTA
        ///</sumary>
        ///<returns></returns>
        public IEnumerable<Persona> GetPersona()
        {
            var persona = DB.Personas.ToList();
            return persona;
        }

        /// <summary>  
        /// se añade o se registra persona
        /// </summary>  
        /// <param name="persona"></param>  
        /// <returns></returns>  
        public Persona AddPersona(Persona persona)
        {
           
            if (persona != null)
            {
                //persona.IdPersona = Guid.NewGuid();
                persona.NombreCompleto = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(persona.Nombres +" "+persona.Apellidos);
                edadCalcular(persona);
                persona.FechaRegistro = DateTime.Now;
                DB.Personas.Add(persona);
                DB.SaveChanges();
                return persona;
            }
            return null;
        }

        /// <summary>  
        /// para actualizar los datos  
        /// </summary>  
        /// <param name="persona"></param>  
        /// <returns></returns>  
        public Persona UpdatePersona(Persona persona)
        {
            edadCalcular(persona);
            DB.Entry(persona).State = EntityState.Modified;
            DB.SaveChanges();
            return persona;
        }
        /// <summary>  
        /// elimina el registro 
        /// </summary>  
        /// <param name="idPersona"></param>  
        /// <returns></returns>  
        public Persona DeletePersona(Guid idPersona)
        {
            var persona = DB.Personas.FirstOrDefault(x => x.IdPersona == idPersona);
            DB.Entry(persona).State = EntityState.Deleted;
            DB.SaveChanges();
            return persona;
        }

        /// <summary>  
        /// traer los detalles del registrado 
        /// </summary>  
        /// <param name="idPersona"></param>  
        /// <returns></returns>  
        public Persona GetPersonaById(Guid idPersona)
        {
            var persona = DB.Personas.FirstOrDefault(x => x.IdPersona == idPersona);
            return persona;
        }


    }
}
