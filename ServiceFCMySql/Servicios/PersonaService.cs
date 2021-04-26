using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using WebServiceFCMySql.IServicios;
using WebServiceFCMySql.Modelos;

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


            DateTime fechaNacimiento = (DateTime)persona.Fechanacimiento;
            int edad = DateTime.Today.Year - fechaNacimiento.Year;
            if (DateTime.Today < fechaNacimiento.AddYears(edad))
                --edad;
            persona.Edad = edad.ToString();


        }
        ///<sumary>
        /// se instancia el contexto de la base de datos
        ///</sumary>
        ///<returns></returns>
        fundacioncolibriContext DB;
        public PersonaService(fundacioncolibriContext db)
        {
            DB = db;
        }

        ///<sumary>
        /// TRAE TODOS LAS PERSONAS REGISTRADAS EN LA FUNDACION EN LISTA
        ///</sumary>
        ///<returns></returns>
        public IEnumerable<Persona> GetPersona(int id)
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
                persona.Nombrecompleto = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(persona.Nombres + " " + persona.Apellidos);
                edadCalcular(persona);
                persona.Fecharegistro = DateTime.Now;
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
            persona.Nombrecompleto = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(persona.Nombres + " " + persona.Apellidos);
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
        public Persona DeletePersona(int idPersona)
        {
            var persona = DB.Personas.FirstOrDefault(x => x.Idpersona == idPersona);
            DB.Entry(persona).State = EntityState.Deleted;
            DB.SaveChanges();
            return persona;
        }

        /// <summary>  
        /// traer los detalles del registrado 
        /// </summary>  
        /// <param name="idPersona"></param>  
        /// <returns></returns>  
        public Persona GetPersonaById(int idPersona)
        {
            var persona = DB.Personas.FirstOrDefault(x => x.Idpersona == idPersona);
            return persona;
        }


    }
}
