using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebServiceFC.Modelos;
using WebServiceFC.IServicios;


namespace WebServiceFC.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase

    {

        private readonly IPersonaService personaService;
        public PersonaController(IPersonaService persona)
        {
            personaService = persona;
        }
        // GET: api/<PersonaController>
        [HttpGet]
        [Route("[action]")]
        [Route("api/Persona/GetPersona")]
        public IEnumerable<Persona> GetPersona()
        {
            return personaService.GetPersona();
        }
        // POST: api/<PersonaController>
        [HttpPost]
        [Route("[action]")]
        [Route("api/Persona/AddPersona")]
        public Persona AddPersona(Persona persona)
        {
            return personaService.AddPersona(persona);
        }
        // PUT: api/<PersonaController>
        [HttpPut]
        [Route("[action]")]
        [Route("api/Persona/EditPersona")]
        public Persona EditPersona(Persona persona)
        {
            return personaService.UpdatePersona(persona);
        }
        // DELETE: api/<PersonaController>
        [HttpDelete]
        [Route("[action]")]
        [Route("api/Persona/DeletePersona")]
        public Persona DeletePersona(Guid idPersona)
        {
            return personaService.DeletePersona(idPersona);
        }
        // GET_ByID: api/<PersonaController>
        [HttpGet]
        [Route("[action]")]
        [Route("api/Persona/GetPersonaId")]
        public Persona GetPersonaById(Guid idPersona)
        {
            return personaService.GetPersonaById(idPersona);
        }
    }
}
