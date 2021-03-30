using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebServiceFC.Modelos;
using WebServiceFC.IServicios;


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
        public IEnumerable<MotivoIngreso> GetMotivoIngreso()
        {
            return motivoIngresoService.GetMotivoIngreso();
        }
        // POST: api/<MotivoIngresoController>
        [HttpPost]
        [Route("[action]")]
        [Route("api/MotivoIngreso/AddMotivoIngreso")]
        public MotivoIngreso AddMotivoIngreso(MotivoIngreso motivoIngreso)
        {
            return motivoIngresoService.AddMotivoIngreso(motivoIngreso);
        }
        // PUT: api/<MotivoIngresoController>
        [HttpPut]
        [Route("[action]")]
        [Route("api/MotivoIngreso/EditMotivoIngreso")]
        public MotivoIngreso EditMotivoIngreso(MotivoIngreso motivoIngreso)
        {
            return motivoIngresoService.UpdateMotivoIngreso(motivoIngreso);
        }
        // DELETE: api/<MotivoIngresoController>
        [HttpDelete]
        [Route("[action]")]
        [Route("api/MotivoIngreso/DeleteMotivoIngreso")]
        public MotivoIngreso DeleteMotivoIngreso(int idMotivoIngreso)
        {
            return motivoIngresoService.DeleteMotivoIngreso(idMotivoIngreso);
        }
        // GET_ByID: api/<MotivoIngresoController>
        [HttpGet]
        [Route("[action]")]
        [Route("api/MotivoIngreso/GetMotivoIngresoId")]
        public MotivoIngreso GetMotivoIngresoById(int idMotivoIngreso)
        {
            return motivoIngresoService.GetMotivoIngresoById(idMotivoIngreso);
        }
    }
}
