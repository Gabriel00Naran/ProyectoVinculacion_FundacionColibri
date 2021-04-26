using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebServiceFCMySql.IServicios;
using WebServiceFCMySql.Modelos;


namespace WebServiceFC.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizacionController : ControllerBase

    {

        private readonly IOrganizacionService organizacionService;
        public OrganizacionController(IOrganizacionService organizacion)
        {
            organizacionService = organizacion;
        }
        // GET: api/<OrganizacionController>
        [HttpGet]
        [Route("[action]")]
        [Route("api/Organizacion/GetOrganizacion")]
        public IEnumerable<Organizacion> GetOrganizacion()
        {
            return organizacionService.GetOrganizacion();
        }
        // POST: api/<OrganizacionController>
        [HttpPost]
        [Route("[action]")]
        [Route("api/Organizacion/AddOrganizacion")]
        public Organizacion AddOrganizacion(Organizacion organizacion)
        {
            return organizacionService.AddOrganizacion(organizacion);
        }
        // PUT: api/<OrganizacionController>
        [HttpPut]
        [Route("[action]")]
        [Route("api/Organizacion/EditOrganizacion")]
        public Organizacion EditOrganizacion(Organizacion organizacion)
        {
            return organizacionService.UpdateOrganizacion(organizacion);
        }
        // DELETE: api/<OrganizacionController>
        [HttpDelete]
        [Route("[action]")]
        [Route("api/Organizacion/DeleteOrganizacion")]
        public Organizacion DeleteOrganizacion(int idOrganizacion)
        {
            return organizacionService.DeleteOrganizacion(idOrganizacion);
        }
        // GET_ByID: api/<OrganizacionController>
        [HttpGet]
        [Route("[action]")]
        [Route("api/Organizacion/GetOrganizacionId")]
        public Organizacion GetOrganizacionById(int idOrganizacion)
        {
            return organizacionService.GetOrganizacionById(idOrganizacion);
        }
    }
}
