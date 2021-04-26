using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebServiceFCMySql.IServicios;
using WebServiceFCMySql.Modelos;


namespace WebServiceFC.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class MotivoIngresoController : ControllerBase

    {

        private readonly IMotivoIngresoService motivoIngresoService;
        public MotivoIngresoController(IMotivoIngresoService motivoIngreso)
        {
            motivoIngresoService = motivoIngreso;
        }
        // GET: api/<MotivoIngresoController>
        [HttpGet]
        [Route("[action]")]
        [Route("api/MotivoIngreso/GetMotivoIngreso")]
        public IEnumerable<Motivoingreso> GetMotivoIngreso()
        {
            return motivoIngresoService.GetMotivoIngreso();
        }
        // POST: api/<MotivoIngresoController>
        [HttpPost]
        [Route("[action]")]
        [Route("api/MotivoIngreso/AddMotivoIngreso")]
        public Motivoingreso AddMotivoIngreso(Motivoingreso motivoIngreso)
        {
            return motivoIngresoService.AddMotivoIngreso(motivoIngreso);
        }
        // PUT: api/<MotivoIngresoController>
        [HttpPut]
        [Route("[action]")]
        [Route("api/MotivoIngreso/EditMotivoIngreso")]
        public Motivoingreso EditMotivoIngreso(Motivoingreso motivoIngreso)
        {
            return motivoIngresoService.UpdateMotivoIngreso(motivoIngreso);
        }
        // DELETE: api/<MotivoIngresoController>
        [HttpDelete]
        [Route("[action]")]
        [Route("api/MotivoIngreso/DeleteMotivoIngreso")]
        public Motivoingreso DeleteMotivoIngreso(int idMotivoIngreso)
        {
            return motivoIngresoService.DeleteMotivoIngreso(idMotivoIngreso);
        }
        // GET_ByID: api/<MotivoIngresoController>
        [HttpGet]
        [Route("[action]")]
        [Route("api/MotivoIngreso/GetMotivoIngresoId")]
        public Motivoingreso GetMotivoIngresoById(int idMotivoIngreso)
        {
            return motivoIngresoService.GetMotivoIngresoById(idMotivoIngreso);
        }
    }
}
