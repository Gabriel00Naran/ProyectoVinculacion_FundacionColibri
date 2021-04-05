using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebServiceFC.Modelos;
using WebServiceFC.IServicios;


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
        public IEnumerable<NudosCritico> GetNudosCritico()
        {
            return personaService.GetNudosCritico();
        }
        // POST: api/<NudosCriticoController>
        [HttpPost]
        [Route("[action]")]
        [Route("api/NudosCritico/AddNudosCritico")]
        public NudosCritico AddNudosCritico(NudosCritico persona)
        {
            return personaService.AddNudosCritico(persona);
        }
        // PUT: api/<NudosCriticoController>
        [HttpPut]
        [Route("[action]")]
        [Route("api/NudosCritico/EditNudosCritico")]
        public NudosCritico EditNudosCritico(NudosCritico persona)
        {
            return personaService.UpdateNudosCritico(persona);
        }
        // DELETE: api/<NudosCriticoController>
        [HttpDelete]
        [Route("[action]")]
        [Route("api/NudosCritico/DeleteNudosCritico")]
        public NudosCritico DeleteNudosCritico(int idNudosCritico)
        {
            return personaService.DeleteNudosCritico(idNudosCritico);
        }
        // GET_ByID: api/<NudosCriticoController>
        [HttpGet]
        [Route("[action]")]
        [Route("api/NudosCritico/GetNudosCriticoId")]
        public NudosCritico GetNudosCriticoById(int idNudosCritico)
        {
            return personaService.GetNudosCriticoById(idNudosCritico);
        }
    }
}
