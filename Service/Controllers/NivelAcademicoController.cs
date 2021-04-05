using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebServiceFC.Modelos;
using WebServiceFC.IServicios;


namespace WebServiceFC.Controllers

{
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
        public IEnumerable<NivelAcademico> GetNivelAcademico()
        {
            return nivelAcademicoService.GetNivelAcademico();
        }
        // POST: api/<NivelAcademicoController>
        [HttpPost]
        [Route("[action]")]
        [Route("api/NivelAcademico/AddNivelAcademico")]
        public NivelAcademico AddNivelAcademico(NivelAcademico nivelAcademico)
        {
            return nivelAcademicoService.AddNivelAcademico(nivelAcademico);
        }
        // PUT: api/<NivelAcademicoController>
        [HttpPut]
        [Route("[action]")]
        [Route("api/NivelAcademico/EditNivelAcademico")]
        public NivelAcademico EditNivelAcademico(NivelAcademico nivelAcademico)
        {
            return nivelAcademicoService.UpdateNivelAcademico(nivelAcademico);
        }
        // DELETE: api/<NivelAcademicoController>
        [HttpDelete]
        [Route("[action]")]
        [Route("api/NivelAcademico/DeleteNivelAcademico")]
        public NivelAcademico DeleteNivelAcademico(int idNivelAcademico)
        {
            return nivelAcademicoService.DeleteNivelAcademico(idNivelAcademico);
        }
        // GET_ByID: api/<NivelAcademicoController>
        [HttpGet]
        [Route("[action]")]
        [Route("api/NivelAcademico/GetNivelAcademicoId")]
        public NivelAcademico GetNivelAcademicoById(int idNivelAcademico)
        {
            return nivelAcademicoService.GetNivelAcademicoById(idNivelAcademico);
        }
    }
}

