using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebServiceFC.Modelos;
using WebServiceFC.IServicios;


namespace WebServiceFC.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class InfraccionDenunciadaController : ControllerBase

    {

        private readonly IInfraccionDenunciadaService infraccionDenunciadaService;
        public InfraccionDenunciadaController(IInfraccionDenunciadaService infraccionDenunciada)
        {
            infraccionDenunciadaService = infraccionDenunciada;
        }
        // GET: api/<InfraccionDenunciadaController>
        [HttpGet]
        [Route("[action]")]
        [Route("api/InfraccionDenunciada/GetInfraccionDenunciada")]
        public IEnumerable<InfraccionDenunciadum> GetInfraccionDenunciada()
        {
            return infraccionDenunciadaService.GetInfraccionDenunciada();
        }
        // POST: api/<InfraccionDenunciadaController>
        [HttpPost]
        [Route("[action]")]
        [Route("api/InfraccionDenunciada/AddInfraccionDenunciada")]
        public InfraccionDenunciadum AddInfraccionDenunciada(InfraccionDenunciadum infraccionDenunciada)
        {
            return infraccionDenunciadaService.AddInfraccionDenunciada(infraccionDenunciada);
        }
        // PUT: api/<InfraccionDenunciadaController>
        [HttpPut]
        [Route("[action]")]
        [Route("api/InfraccionDenunciada/EditInfraccionDenunciada")]
        public InfraccionDenunciadum EditInfraccionDenunciada(InfraccionDenunciadum infraccionDenunciada)
        {
            return infraccionDenunciadaService.UpdateInfraccionDenunciada(infraccionDenunciada);
        }
        // DELETE: api/<InfraccionDenunciadaController>
        [HttpDelete]
        [Route("[action]")]
        [Route("api/InfraccionDenunciada/DeleteInfraccionDenunciada")]
        public InfraccionDenunciadum DeleteInfraccionDenunciada(int idInfraccionDenunciada)
        {
            return infraccionDenunciadaService.DeleteInfraccionDenunciada(idInfraccionDenunciada);
        }
        // GET_ByID: api/<InfraccionDenunciadaController>
        [HttpGet]
        [Route("[action]")]
        [Route("api/InfraccionDenunciada/GetInfraccionDenunciadaId")]
        public InfraccionDenunciadum GetInfraccionDenunciadaById(int idInfraccionDenunciada)
        {
            return infraccionDenunciadaService.GetInfraccionDenunciadaById(idInfraccionDenunciada);
        }
    }
}
