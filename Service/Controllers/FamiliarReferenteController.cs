using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebServiceFC.Modelos;
using WebServiceFC.IServicios;


namespace WebServiceFC.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class FamiliarReferenteController : ControllerBase

    {

        private readonly IFamiliarReferenteService familiarReferenteService;
        public FamiliarReferenteController(IFamiliarReferenteService familiarReferente)
        {
            familiarReferenteService = familiarReferente;
        }
        // GET: api/<FamiliarReferenteController>
        [HttpGet]
        [Route("[action]")]
        [Route("api/FamiliarReferente/GetFamiliarReferente")]
        public IEnumerable<FamiliarReferente> GetFamiliarReferente()
        {
            return familiarReferenteService.GetFamiliarReferente();
        }
        // POST: api/<FamiliarReferenteController>
        [HttpPost]
        [Route("[action]")]
        [Route("api/FamiliarReferente/AddFamiliarReferente")]
        public FamiliarReferente AddFamiliarReferente(FamiliarReferente familiarReferente)
        {
            return familiarReferenteService.AddFamiliarReferente(familiarReferente);
        }
        // PUT: api/<FamiliarReferenteController>
        [HttpPut]
        [Route("[action]")]
        [Route("api/FamiliarReferente/EditFamiliarReferente")]
        public FamiliarReferente EditFamiliarReferente(FamiliarReferente familiarReferente)
        {
            return familiarReferenteService.UpdateFamiliarReferente(familiarReferente);
        }
        // DELETE: api/<FamiliarReferenteController>
        [HttpDelete]
        [Route("[action]")]
        [Route("api/FamiliarReferente/DeleteFamiliarReferente")]
        public FamiliarReferente DeleteFamiliarReferente(int idFamiliarReferente)
        {
            return familiarReferenteService.DeleteFamiliarReferente(idFamiliarReferente);
        }
        // GET_ByID: api/<FamiliarReferenteController>
        [HttpGet]
        [Route("[action]")]
        [Route("api/FamiliarReferente/GetFamiliarReferenteId")]
        public FamiliarReferente GetFamiliarReferenteById(int idFamiliarReferente)
        {
            return familiarReferenteService.GetFamiliarReferenteById(idFamiliarReferente);
        }
    }
}
