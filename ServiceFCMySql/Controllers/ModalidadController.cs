using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebServiceFCMySql.IServicios;
using WebServiceFCMySql.Modelos;


namespace WebServiceFC.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class ModalidadController : ControllerBase

    {

        private readonly IModalidadService modalidadService;
        public ModalidadController(IModalidadService modalidad)
        {
            modalidadService = modalidad;
        }
        // GET: api/<ModalidadController>
        [HttpGet]
        [Route("[action]")]
        [Route("api/Modalidad/GetModalidad")]
        public IEnumerable<Modalidad> GetModalidad()
        {
            return modalidadService.GetModalidad();
        }
        // POST: api/<ModalidadController>
        [HttpPost]
        [Route("[action]")]
        [Route("api/Modalidad/AddModalidad")]
        public Modalidad AddModalidad(Modalidad modalidad)
        {
            return modalidadService.AddModalidad(modalidad);
        }
        // PUT: api/<ModalidadController>
        [HttpPut]
        [Route("[action]")]
        [Route("api/Modalidad/EditModalidad")]
        public Modalidad EditModalidad(Modalidad modalidad)
        {
            return modalidadService.UpdateModalidad(modalidad);
        }
        // DELETE: api/<ModalidadController>
        [HttpDelete]
        [Route("[action]")]
        [Route("api/Modalidad/DeleteModalidad")]
        public Modalidad DeleteModalidad(int idModalidad)
        {
            return modalidadService.DeleteModalidad(idModalidad);
        }
        // GET_ByID: api/<ModalidadController>
        [HttpGet]
        [Route("[action]")]
        [Route("api/Modalidad/GetModalidadId")]
        public Modalidad GetModalidadById(int idModalidad)
        {
            return modalidadService.GetModalidadById(idModalidad);
        }
    }
}
