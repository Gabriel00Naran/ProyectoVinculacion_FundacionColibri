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
    public class CasaAcogimientoController : ControllerBase

    {

        private readonly ICasaAcogimientoService casaAcogimientoService;
        public CasaAcogimientoController(ICasaAcogimientoService casaAcogimiento)
        {
            casaAcogimientoService = casaAcogimiento;
        }
        // GET: api/<CasaAcogimientoController>
        [HttpGet]
        [Route("[action]")]
        [Route("api/CasaAcogimiento/GetCasaAcogimiento")]
        public IEnumerable<Casaacogimiento> GetCasaAcogimiento()
        {
            return casaAcogimientoService.GetCasaAcogimiento();
        }
        // POST: api/<CasaAcogimientoController>
        [HttpPost]
        [Route("[action]")]
        [Route("api/CasaAcogimiento/AddCasaAcogimiento")]
        public Casaacogimiento AddCasaAcogimiento(Casaacogimiento casaAcogimiento)
        {
            return casaAcogimientoService.AddCasaAcogimiento(casaAcogimiento);
        }
        // PUT: api/<CasaAcogimientoController>
        [HttpPut]
        [Route("[action]")]
        [Route("api/CasaAcogimiento/EditCasaAcogimiento")]
        public Casaacogimiento EditCasaAcogimiento(Casaacogimiento casaAcogimiento)
        {
            return casaAcogimientoService.UpdateCasaAcogimiento(casaAcogimiento);
        }
        // DELETE: api/<CasaAcogimientoController>
        [HttpDelete]
        [Route("[action]")]
        [Route("api/CasaAcogimiento/DeleteCasaAcogimiento")]
        public Casaacogimiento DeleteCasaAcogimiento(int idNombreCasaAnterior)
        {
            return casaAcogimientoService.DeleteCasaAcogimiento(idNombreCasaAnterior);
        }
        // GET_ByID: api/<CasaAcogimientoController>
        [HttpGet]
        [Route("[action]")]
        [Route("api/CasaAcogimiento/GetCasaAcogimientoId")]
        public Casaacogimiento GetCasaAcogimientoById(int idNombreCasaAnterior)
        {
            return casaAcogimientoService.GetCasaAcogimientoById(idNombreCasaAnterior);
        }
    }
}
