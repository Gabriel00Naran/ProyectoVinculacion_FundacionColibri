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
        public IEnumerable<Datosjudicialpenal> GetDatosJudicialPenal()
        {
            return judicialPenalService.GetDatosJudicialPenal();
        }
        // POST: api/<DatosJudicialPenalController>
        [HttpPost]
        [Route("[action]")]
        [Route("api/DatosJudicialPenal/AddDatosJudicialPenal")]
        public Datosjudicialpenal AddDatosJudicialPenal(Datosjudicialpenal judicialPenal)
        {
            return judicialPenalService.AddDatosJudicialPenal(judicialPenal);
        }
        // PUT: api/<DatosJudicialPenalController>
        [HttpPut]
        [Route("[action]")]
        [Route("api/DatosJudicialPenal/EditDatosJudicialPenal")]
        public Datosjudicialpenal EditDatosJudicialPenal(Datosjudicialpenal judicialPenal)
        {
            return judicialPenalService.UpdateDatosJudicialPenal(judicialPenal);
        }
        // DELETE: api/<DatosJudicialPenalController>
        [HttpDelete]
        [Route("[action]")]
        [Route("api/DatosJudicialPenal/DeleteDatosJudicialPenal")]
        public Datosjudicialpenal DeleteDatosJudicialPenal(int idJudicialPenal)
        {
            return judicialPenalService.DeleteDatosJudicialPenal(idJudicialPenal);
        }
        // GET_ByID: api/<DatosJudicialPenalController>
        [HttpGet]
        [Route("[action]")]
        [Route("api/DatosJudicialPenal/GetDatosJudicialPenalId")]
        public Datosjudicialpenal GetDatosJudicialPenalById(int idJudicialPenal)
        {
            return judicialPenalService.GetDatosJudicialPenalById(idJudicialPenal);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/DatosJudicialPenal/GetDatosJudicialPenalIdPersona")]
        public List<Datosjudicialpenal> GetDatosJudicialPenalByIdPersona(int idpersona)
        {
            return judicialPenalService.GetDatosJudicialPenalByIdPersona(idpersona);
        }
    }
}
