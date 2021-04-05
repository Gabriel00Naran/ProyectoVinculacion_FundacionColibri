using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebServiceFC.Modelos;
using WebServiceFC.IServicios;


namespace WebServiceFC.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class DatosJudicialPenalController : ControllerBase

    {

        private readonly IDatosJudicialPenalService judicialPenalService;
        public DatosJudicialPenalController(IDatosJudicialPenalService judicialPenal)
        {
            judicialPenalService = judicialPenal;
        }
        // GET: api/<DatosJudicialPenalController>
        [HttpGet]
        [Route("[action]")]
        [Route("api/DatosJudicialPenal/GetDatosJudicialPenal")]
        public IEnumerable<DatosJudicialPenal> GetDatosJudicialPenal()
        {
            return judicialPenalService.GetDatosJudicialPenal();
        }
        // POST: api/<DatosJudicialPenalController>
        [HttpPost]
        [Route("[action]")]
        [Route("api/DatosJudicialPenal/AddDatosJudicialPenal")]
        public DatosJudicialPenal AddDatosJudicialPenal(DatosJudicialPenal judicialPenal)
        {
            return judicialPenalService.AddDatosJudicialPenal(judicialPenal);
        }
        // PUT: api/<DatosJudicialPenalController>
        [HttpPut]
        [Route("[action]")]
        [Route("api/DatosJudicialPenal/EditDatosJudicialPenal")]
        public DatosJudicialPenal EditDatosJudicialPenal(DatosJudicialPenal judicialPenal)
        {
            return judicialPenalService.UpdateDatosJudicialPenal(judicialPenal);
        }
        // DELETE: api/<DatosJudicialPenalController>
        [HttpDelete]
        [Route("[action]")]
        [Route("api/DatosJudicialPenal/DeleteDatosJudicialPenal")]
        public DatosJudicialPenal DeleteDatosJudicialPenal(Guid idJudicialPenal)
        {
            return judicialPenalService.DeleteDatosJudicialPenal(idJudicialPenal);
        }
        // GET_ByID: api/<DatosJudicialPenalController>
        [HttpGet]
        [Route("[action]")]
        [Route("api/DatosJudicialPenal/GetDatosJudicialPenalId")]
        public DatosJudicialPenal GetDatosJudicialPenalById(Guid idJudicialPenal)
        {
            return judicialPenalService.GetDatosJudicialPenalById(idJudicialPenal);
        }
    }
}
