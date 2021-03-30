using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebServiceFC.Modelos;
using WebServiceFC.IServicios;


namespace WebServiceFC.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class EtniaController : ControllerBase

    {

        private readonly IEtniaService etniaService;
        public EtniaController(IEtniaService etnia)
        {
            etniaService = etnia;
        }
        // GET: api/<EtniaController>
        [HttpGet]
        [Route("[action]")]
        [Route("api/Etnia/GetEtnia")]
        public IEnumerable<Etnium> GetEtnia()
        {
            return etniaService.GetEtnia();
        }
        // POST: api/<EtniaController>
        [HttpPost]
        [Route("[action]")]
        [Route("api/Etnia/AddEtnia")]
        public Etnium AddEtnia(Etnium etnia)
        {
            return etniaService.AddEtnia(etnia);
        }
        // PUT: api/<EtniaController>
        [HttpPut]
        [Route("[action]")]
        [Route("api/Etnia/EditEtnia")]
        public Etnium EditEtnia(Etnium etnia)
        {
            return etniaService.UpdateEtnia(etnia);
        }
        // DELETE: api/<EtniaController>
        [HttpDelete]
        [Route("[action]")]
        [Route("api/Etnia/DeleteEtnia")]
        public Etnium DeleteEtnia(int idEtnia)
        {
            return etniaService.DeleteEtnia(idEtnia);
        }
        // GET_ByID: api/<EtniumController>
        [HttpGet]
        [Route("[action]")]
        [Route("api/Etnia/GetEtniaId")]
        public Etnium GetEtniumById(int idEtnia)
        {
            return etniaService.GetEtniaById(idEtnia);
        }
    }
}
