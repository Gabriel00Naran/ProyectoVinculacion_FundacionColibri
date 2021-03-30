using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebServiceFC.Modelos;
using WebServiceFC.IServicios;


namespace WebServiceFC.Controllers

{
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
        public IEnumerable<CasaAcogimiento> GetCasaAcogimiento()
        {
            return casaAcogimientoService.GetCasaAcogimiento();
        }
        // POST: api/<CasaAcogimientoController>
        [HttpPost]
        [Route("[action]")]
        [Route("api/CasaAcogimiento/AddCasaAcogimiento")]
        public CasaAcogimiento AddCasaAcogimiento(CasaAcogimiento casaAcogimiento)
        {
            return casaAcogimientoService.AddCasaAcogimiento(casaAcogimiento);
        }
        // PUT: api/<CasaAcogimientoController>
        [HttpPut]
        [Route("[action]")]
        [Route("api/CasaAcogimiento/EditCasaAcogimiento")]
        public CasaAcogimiento EditCasaAcogimiento(CasaAcogimiento casaAcogimiento)
        {
            return casaAcogimientoService.UpdateCasaAcogimiento(casaAcogimiento);
        }
        // DELETE: api/<CasaAcogimientoController>
        [HttpDelete]
        [Route("[action]")]
        [Route("api/CasaAcogimiento/DeleteCasaAcogimiento")]
        public CasaAcogimiento DeleteCasaAcogimiento(int idNombreCasaAnterior)
        {
            return casaAcogimientoService.DeleteCasaAcogimiento(idNombreCasaAnterior);
        }
        // GET_ByID: api/<CasaAcogimientoController>
        [HttpGet]
        [Route("[action]")]
        [Route("api/CasaAcogimiento/GetCasaAcogimientoId")]
        public CasaAcogimiento GetCasaAcogimientoById(int idNombreCasaAnterior)
        {
            return casaAcogimientoService.GetCasaAcogimientoById(idNombreCasaAnterior);
        }
    }
}
