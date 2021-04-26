using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebServiceFCMySql.IServicios;
using WebServiceFCMySql.Modelos;


namespace WebServiceFC.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class NudosCriticoController : ControllerBase

    {

        private readonly INudosCriticoService personaService;
        public NudosCriticoController(INudosCriticoService persona)
        {
            personaService = persona;
        }
        // GET: api/<NudosCriticoController>
        [HttpGet]
        [Route("[action]")]
        [Route("api/NudosCritico/GetNudosCritico")]
        public IEnumerable<Nudoscritico> GetNudosCritico()
        {
            return personaService.GetNudosCritico();
        }
        // POST: api/<NudosCriticoController>
        [HttpPost]
        [Route("[action]")]
        [Route("api/NudosCritico/AddNudosCritico")]
        public Nudoscritico AddNudosCritico(Nudoscritico persona)
        {
            return personaService.AddNudosCritico(persona);
        }
        // PUT: api/<NudosCriticoController>
        [HttpPut]
        [Route("[action]")]
        [Route("api/NudosCritico/EditNudosCritico")]
        public Nudoscritico EditNudosCritico(Nudoscritico persona)
        {
            return personaService.UpdateNudosCritico(persona);
        }
        // DELETE: api/<NudosCriticoController>
        [HttpDelete]
        [Route("[action]")]
        [Route("api/NudosCritico/DeleteNudosCritico")]
        public Nudoscritico DeleteNudosCritico(int idNudosCritico)
        {
            return personaService.DeleteNudosCritico(idNudosCritico);
        }
        // GET_ByID: api/<NudosCriticoController>
        [HttpGet]
        [Route("[action]")]
        [Route("api/NudosCritico/GetNudosCriticoId")]
        public Nudoscritico GetNudosCriticoById(int idNudosCritico)
        {
            return personaService.GetNudosCriticoById(idNudosCritico);
        }
    }
}
