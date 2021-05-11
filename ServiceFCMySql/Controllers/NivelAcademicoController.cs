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
    public class NivelAcademicoController : ControllerBase

    {

        private readonly INivelAcademicoService nivelAcademicoService;
        public NivelAcademicoController(INivelAcademicoService nivelAcademico)
        {
            nivelAcademicoService = nivelAcademico;
        }
        // GET: api/<NivelAcademicoController>
        [HttpGet]
        [Route("[action]")]
        [Route("api/NivelAcademico/GetNivelAcademico")]
        public IEnumerable<Nivelacademico> GetNivelAcademico()
        {
            return nivelAcademicoService.GetNivelAcademico();
        }
        // POST: api/<NivelAcademicoController>
        [HttpPost]
        [Route("[action]")]
        [Route("api/NivelAcademico/AddNivelAcademico")]
        public Nivelacademico AddNivelAcademico(Nivelacademico nivelAcademico)
        {
            return nivelAcademicoService.AddNivelAcademico(nivelAcademico);
        }
        // PUT: api/<NivelAcademicoController>
        [HttpPut]
        [Route("[action]")]
        [Route("api/NivelAcademico/EditNivelAcademico")]
        public Nivelacademico EditNivelAcademico(Nivelacademico nivelAcademico)
        {
            return nivelAcademicoService.UpdateNivelAcademico(nivelAcademico);
        }
        // DELETE: api/<NivelAcademicoController>
        [HttpDelete]
        [Route("[action]")]
        [Route("api/NivelAcademico/DeleteNivelAcademico")]
        public Nivelacademico DeleteNivelAcademico(int idNivelAcademico)
        {
            return nivelAcademicoService.DeleteNivelAcademico(idNivelAcademico);
        }
        // GET_ByID: api/<NivelAcademicoController>
        [HttpGet]
        [Route("[action]")]
        [Route("api/NivelAcademico/GetNivelAcademicoId")]
        public Nivelacademico GetNivelAcademicoById(int idNivelAcademico)
        {
            return nivelAcademicoService.GetNivelAcademicoById(idNivelAcademico);
        }
    }
}

