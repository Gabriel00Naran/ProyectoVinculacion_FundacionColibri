using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebServiceFCMySql.IServicios;
using WebServiceFCMySql.Modelos;


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
        public IEnumerable<Familiarreferente> GetFamiliarReferente()
        {
            return familiarReferenteService.GetFamiliarReferente();
        }
        // POST: api/<FamiliarReferenteController>
        [HttpPost]
        [Route("[action]")]
        [Route("api/FamiliarReferente/AddFamiliarReferente")]
        public Familiarreferente AddFamiliarReferente(Familiarreferente familiarReferente)
        {
            return familiarReferenteService.AddFamiliarReferente(familiarReferente);
        }
        // PUT: api/<FamiliarReferenteController>
        [HttpPut]
        [Route("[action]")]
        [Route("api/FamiliarReferente/EditFamiliarReferente")]
        public Familiarreferente EditFamiliarReferente(Familiarreferente familiarReferente)
        {
            return familiarReferenteService.UpdateFamiliarReferente(familiarReferente);
        }
        // DELETE: api/<FamiliarReferenteController>
        [HttpDelete]
        [Route("[action]")]
        [Route("api/FamiliarReferente/DeleteFamiliarReferente")]
        public Familiarreferente DeleteFamiliarReferente(int idFamiliarReferente)
        {
            return familiarReferenteService.DeleteFamiliarReferente(idFamiliarReferente);
        }
        // GET_ByID: api/<FamiliarReferenteController>
        [HttpGet]
        [Route("[action]")]
        [Route("api/FamiliarReferente/GetFamiliarReferenteId")]
        public Familiarreferente GetFamiliarReferenteById(int idFamiliarReferente)
        {
            return familiarReferenteService.GetFamiliarReferenteById(idFamiliarReferente);
        }
    }
}
