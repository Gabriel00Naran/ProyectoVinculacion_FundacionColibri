using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebServiceFCMySql.IServicios;
using WebServiceFCMySql.Modelos;


namespace WebServiceFC.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class DatosSaludController : ControllerBase

    {

        private readonly IDatosSaludService datosSaludService;
        public DatosSaludController(IDatosSaludService datosSalud)
        {
            datosSaludService = datosSalud;
        }
        // GET: api/<DatosSaludController>
        [HttpGet]
        [Route("[action]")]
        [Route("api/DatosSalud/GetDatosSalud")]
        public IEnumerable<Datossalud> GetDatosSalud()
        {
            return datosSaludService.GetDatosSalud();
        }
        // POST: api/<DatosSaludController>
        [HttpPost]
        [Route("[action]")]
        [Route("api/DatosSalud/AddDatosSalud")]
        public Datossalud AddDatosSalud(Datossalud datosSalud)
        {
            return datosSaludService.AddDatosSalud(datosSalud);
        }
        // PUT: api/<DatosSaludController>
        [HttpPut]
        [Route("[action]")]
        [Route("api/DatosSalud/EditDatosSalud")]
        public Datossalud EditDatosSalud(Datossalud datosSalud)
        {
            return datosSaludService.UpdateDatosSalud(datosSalud);
        }
        // DELETE: api/<DatosSaludController>
        [HttpDelete]
        [Route("[action]")]
        [Route("api/DatosSalud/DeleteDatosSalud")]
        public Datossalud DeleteDatosSalud(int idDatosSalud)
        {
            return datosSaludService.DeleteDatosSalud(idDatosSalud);
        }
        // GET_ByID: api/<DatosSaludController>
        [HttpGet]
        [Route("[action]")]
        [Route("api/DatosSalud/GetDatosSaludId")]
        public Datossalud GetDatosSaludById(int idDatosSalud)
        {
            return datosSaludService.GetDatosSaludById(idDatosSalud);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/DatosSalud/GetDatosSaludIdPersona")]
        public List<Datossalud> GetDatosSaludByIdPersona(int idpersona)
        {
            return datosSaludService.GetDatosSaludByIdPersona(idpersona);
        }

    }
}
