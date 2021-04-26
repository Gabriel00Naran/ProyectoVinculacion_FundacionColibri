using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebServiceFCMySql.IServicios;
using WebServiceFCMySql.Modelos;


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
        public IEnumerable<Infracciondenunciadum> GetInfraccionDenunciada()
        {
            return infraccionDenunciadaService.GetInfraccionDenunciada();
        }
        // POST: api/<InfraccionDenunciadaController>
        [HttpPost]
        [Route("[action]")]
        [Route("api/InfraccionDenunciada/AddInfraccionDenunciada")]
        public Infracciondenunciadum AddInfraccionDenunciada(Infracciondenunciadum infraccionDenunciada)
        {
            return infraccionDenunciadaService.AddInfraccionDenunciada(infraccionDenunciada);
        }
        // PUT: api/<InfraccionDenunciadaController>
        [HttpPut]
        [Route("[action]")]
        [Route("api/InfraccionDenunciada/EditInfraccionDenunciada")]
        public Infracciondenunciadum EditInfraccionDenunciada(Infracciondenunciadum infraccionDenunciada)
        {
            return infraccionDenunciadaService.UpdateInfraccionDenunciada(infraccionDenunciada);
        }
        // DELETE: api/<InfraccionDenunciadaController>
        [HttpDelete]
        [Route("[action]")]
        [Route("api/InfraccionDenunciada/DeleteInfraccionDenunciada")]
        public Infracciondenunciadum DeleteInfraccionDenunciada(int idInfraccionDenunciada)
        {
            return infraccionDenunciadaService.DeleteInfraccionDenunciada(idInfraccionDenunciada);
        }
        // GET_ByID: api/<InfraccionDenunciadaController>
        [HttpGet]
        [Route("[action]")]
        [Route("api/InfraccionDenunciada/GetInfraccionDenunciadaId")]
        public Infracciondenunciadum GetInfraccionDenunciadaById(int idInfraccionDenunciada)
        {
            return infraccionDenunciadaService.GetInfraccionDenunciadaById(idInfraccionDenunciada);
        }
    }
}
