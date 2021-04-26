using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebServiceFCMySql.IServicios;
using WebServiceFCMySql.Modelos;


namespace WebServiceFC.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadoProcesalController : ControllerBase

    {

        private readonly IEstadoProcesalService estadoProcesalService;
        public EstadoProcesalController(IEstadoProcesalService estadoProcesal)
        {
            estadoProcesalService = estadoProcesal;
        }
        // GET: api/<EstadoProcesalController>
        [HttpGet]
        [Route("[action]")]
        [Route("api/EstadoProcesal/GetEstadoProcesal")]
        public IEnumerable<Estadoprocesal> GetEstadoProcesal()
        {
            return estadoProcesalService.GetEstadoProcesal();
        }
        // POST: api/<EstadoProcesalController>
        [HttpPost]
        [Route("[action]")]
        [Route("api/EstadoProcesal/AddEstadoProcesal")]
        public Estadoprocesal AddEstadoProcesal(Estadoprocesal estadoProcesal)
        {
            return estadoProcesalService.AddEstadoProcesal(estadoProcesal);
        }
        // PUT: api/<EstadoProcesalController>
        [HttpPut]
        [Route("[action]")]
        [Route("api/EstadoProcesal/EditEstadoProcesal")]
        public Estadoprocesal EditEstadoProcesal(Estadoprocesal estadoProcesal)
        {
            return estadoProcesalService.UpdateEstadoProcesal(estadoProcesal);
        }
        // DELETE: api/<EstadoProcesalController>
        [HttpDelete]
        [Route("[action]")]
        [Route("api/EstadoProcesal/DeleteEstadoProcesal")]
        public Estadoprocesal DeleteEstadoProcesal(int idEstadoProcesal)
        {
            return estadoProcesalService.DeleteEstadoProcesal(idEstadoProcesal);
        }
        // GET_ByID: api/<EstadoProcesalController>
        [HttpGet]
        [Route("[action]")]
        [Route("api/EstadoProcesal/GetEstadoProcesalId")]
        public Estadoprocesal GetEstadoProcesalById(int idEstadoProcesal)
        {
            return estadoProcesalService.GetEstadoProcesalById(idEstadoProcesal);
        }
    }
}
