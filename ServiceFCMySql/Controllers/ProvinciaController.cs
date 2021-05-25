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
    public class ProvinciaController : ControllerBase

    {

        private readonly IProvinciaService provinciaService;
        public ProvinciaController(IProvinciaService provincia)
        {
            provinciaService = provincia;
        }
        // GET: api/<ProvinciaController>
        [HttpGet]
        [Route("[action]")]
        [Route("api/Provincia/GetProvincia")]
        public IEnumerable<Provincium> GetProvincia()
        {
            return provinciaService.GetProvincia();
        }
        // POST: api/<ProvinciaController>
        [HttpPost]
        [Route("[action]")]
        [Route("api/Provincia/AddProvincia")]
        public Provincium AddProvincia(Provincium provincia)
        {
            return provinciaService.AddProvincia(provincia);
        }
        // PUT: api/<ProvinciaController>
        [HttpPut]
        [Route("[action]")]
        [Route("api/Provincia/EditProvincia")]
        public Provincium EditProvincia(Provincium provincia)
        {
            return provinciaService.UpdateProvincia(provincia);
        }
        // DELETE: api/<ProvinciaController>
        [HttpDelete]
        [Route("[action]")]
        [Route("api/Provincia/DeleteProvincia")]
        public Provincium DeleteProvincia(int idProvincia)
        {
            return provinciaService.DeleteProvincia(idProvincia);
        }
        // GET_ByID: api/<ProvinciaController>
        [HttpGet]
        [Route("[action]")]
        [Route("api/Provincia/GetProvinciaId")]
        public Provincium GetProvinciaById(int idProvincia)
        {
            return provinciaService.GetProvinciaById(idProvincia);
        }
    }
}
