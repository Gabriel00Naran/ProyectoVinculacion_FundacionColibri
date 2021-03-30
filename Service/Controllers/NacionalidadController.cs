using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebServiceFC.Modelos;
using WebServiceFC.IServicios;


namespace WebServiceFC.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class NacionalidadController : ControllerBase

    {

        private readonly INacionalidadService nacionalidadService;
        public NacionalidadController(INacionalidadService nacionalidad)
        {
            nacionalidadService = nacionalidad;
        }
        // GET: api/<NacionalidadController>
        [HttpGet]
        [Route("[action]")]
        [Route("api/Nacionalidad/GetNacionalidad")]
        public IEnumerable<Nacionalidad> GetNacionalidad()
        {
            return nacionalidadService.GetNacionalidad();
        }
        // POST: api/<NacionalidadController>
        [HttpPost]
        [Route("[action]")]
        [Route("api/Nacionalidad/AddNacionalidad")]
        public Nacionalidad AddNacionalidad(Nacionalidad nacionalidad)
        {
            return nacionalidadService.AddNacionalidad(nacionalidad);
        }
        // PUT: api/<NacionalidadController>
        [HttpPut]
        [Route("[action]")]
        [Route("api/Nacionalidad/EditNacionalidad")]
        public Nacionalidad EditNacionalidad(Nacionalidad nacionalidad)
        {
            return nacionalidadService.UpdateNacionalidad(nacionalidad);
        }
        // DELETE: api/<NacionalidadController>
        [HttpDelete]
        [Route("[action]")]
        [Route("api/Nacionalidad/DeleteNacionalidad")]
        public Nacionalidad DeleteNacionalidad(int idNacionalidad)
        {
            return nacionalidadService.DeleteNacionalidad(idNacionalidad);
        }
        // GET_ByID: api/<NacionalidadController>
        [HttpGet]
        [Route("[action]")]
        [Route("api/Nacionalidad/GetNacionalidadId")]
        public Nacionalidad GetNacionalidadById(int idNacionalidad)
        {
            return nacionalidadService.GetNacionalidadById(idNacionalidad);
        }
    }
}
