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
    public class MedidaController : ControllerBase

    {

        private readonly IMedidaService medidaService;
        public MedidaController(IMedidaService medida)
        {
            medidaService = medida;
        }
        // GET: api/<MedidaController>
        [HttpGet]
        [Route("[action]")]
        [Route("api/Medida/GetMedida")]
        public IEnumerable<Medidum> GetMedida()
        {
            return medidaService.GetMedida();
        }
        // POST: api/<MedidaController>
        [HttpPost]
        [Route("[action]")]
        [Route("api/Medida/AddMedida")]
        public Medidum AddMedida(Medidum medida)
        {
            return medidaService.AddMedida(medida);
        }
        // PUT: api/<MedidaController>
        [HttpPut]
        [Route("[action]")]
        [Route("api/Medida/EditMedida")]
        public Medidum EditMedida(Medidum medida)
        {
            return medidaService.UpdateMedida(medida);
        }
        // DELETE: api/<MedidaController>
        [HttpDelete]
        [Route("[action]")]
        [Route("api/Medida/DeleteMedida")]
        public Medidum DeleteMedida(int idMedida)
        {
            return medidaService.DeleteMedida(idMedida);
        }
        // GET_ByID: api/<MedidaController>
        [HttpGet]
        [Route("[action]")]
        [Route("api/Medida/GetMedidaId")]
        public Medidum GetMedidaById(int idMedida)
        {
            return medidaService.GetMedidaById(idMedida);
        }
    }
}
