using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebServiceFC.Modelos;
using WebServiceFC.IServicios;


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
        public IEnumerable<DatosSalud> GetDatosSalud()
        {
            return datosSaludService.GetDatosSalud();
        }
        // POST: api/<DatosSaludController>
        [HttpPost]
        [Route("[action]")]
        [Route("api/DatosSalud/AddDatosSalud")]
        public DatosSalud AddDatosSalud(DatosSalud datosSalud)
        {
            return datosSaludService.AddDatosSalud(datosSalud);
        }
        // PUT: api/<DatosSaludController>
        [HttpPut]
        [Route("[action]")]
        [Route("api/DatosSalud/EditDatosSalud")]
        public DatosSalud EditDatosSalud(DatosSalud datosSalud)
        {
            return datosSaludService.UpdateDatosSalud(datosSalud);
        }
        // DELETE: api/<DatosSaludController>
        [HttpDelete]
        [Route("[action]")]
        [Route("api/DatosSalud/DeleteDatosSalud")]
        public DatosSalud DeleteDatosSalud(Guid idDatosSalud)
        {
            return datosSaludService.DeleteDatosSalud(idDatosSalud);
        }
        // GET_ByID: api/<DatosSaludController>
        [HttpGet]
        [Route("[action]")]
        [Route("api/DatosSalud/GetDatosSaludId")]
        public DatosSalud GetDatosSaludById(Guid idDatosSalud)
        {
            return datosSaludService.GetDatosSaludById(idDatosSalud);
        }
    }
}
