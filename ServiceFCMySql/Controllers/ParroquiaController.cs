using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebServiceFCMySql.IServicios;
using WebServiceFCMySql.Modelos;


namespace WebServiceFC.Controllers

{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ParroquiaController : ControllerBase

    {

        private readonly IParroquiaService parroquiaService;
        public ParroquiaController(IParroquiaService parroquia)
        {
            parroquiaService = parroquia;
        }
        // GET: api/<ParroquiaController>
        [HttpGet]
        [Route("[action]")]
        [Route("api/Parroquia/GetParroquia")]
        public IEnumerable<Parroquium> GetParroquia()
        {
            return parroquiaService.GetParroquia();
        }
        // POST: api/<ParroquiaController>
        [HttpPost]
        [Route("[action]")]
        [Route("api/Parroquia/AddParroquia")]
        public Parroquium AddParroquia(Parroquium parroquia)
        {
            return parroquiaService.AddParroquia(parroquia);
        }
        // PUT: api/<ParroquiaController>
        [HttpPut]
        [Route("[action]")]
        [Route("api/Parroquia/EditParroquia")]
        public Parroquium EditParroquia(Parroquium parroquia)
        {
            return parroquiaService.UpdateParroquia(parroquia);
        }
        // DELETE: api/<ParroquiaController>
        [HttpDelete]
        [Route("[action]")]
        [Route("api/Parroquia/DeleteParroquia")]
        public Parroquium DeleteParroquia(int idParroquia)
        {
            return parroquiaService.DeleteParroquia(idParroquia);
        }
        // GET_ByID: api/<ParroquiaController>
        [HttpGet]
        [Route("[action]")]
        [Route("api/Parroquia/GetParroquiaId")]
        public Parroquium GetParroquiaById(int idParroquium)
        {
            return parroquiaService.GetParroquiaById(idParroquium);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Canton/GetParroquiaIdCanton")]
        public List<Parroquium> GetParroquiaByIdCanton(int idcanton)
        {
            return parroquiaService.GetParroquiaByIdCanton(idcanton);
        }
    }
}
