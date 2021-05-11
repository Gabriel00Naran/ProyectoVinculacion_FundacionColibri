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
    public class CantonController : ControllerBase

    {

        private readonly ICantonService cantonService;
        public CantonController(ICantonService canton)
        {
            cantonService = canton;
        }
        // GET: api/<CantonController>
        [HttpGet]
        [Route("[action]")]
        [Route("api/Canton/GetCanton")]
        public IEnumerable<Canton> GetCanton()
        {
            return cantonService.GetCanton();
        }
        // POST: api/<CantonController>
        [HttpPost]
        [Route("[action]")]
        [Route("api/Canton/AddCanton")]
        public Canton AddCanton(Canton canton)
        {
            return cantonService.AddCanton(canton);
        }
        // PUT: api/<CantonController>
        [HttpPut]
        [Route("[action]")]
        [Route("api/Canton/EditCanton")]
        public Canton EditCanton(Canton canton)
        {
            return cantonService.UpdateCanton(canton);
        }
        // DELETE: api/<CantonController>
        [HttpDelete]
        [Route("[action]")]
        [Route("api/Canton/DeleteCanton")]
        public Canton DeleteCanton(int idCanton)
        {
            return cantonService.DeleteCanton(idCanton);
        }
        // GET_ByID: api/<CantonController>
        [HttpGet]
        [Route("[action]")]
        [Route("api/Canton/GetCantonId")]
        public Canton GetCantonById(int idCanton)
        {
            return cantonService.GetCantonById(idCanton);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Canton/GetCantonIdProvincia")]
        public List<Canton> GetCantonByIdProvincia(int idprovincia)
        {
            return cantonService.GetCantonByIdProvincia(idprovincia);
        }
    }
}
