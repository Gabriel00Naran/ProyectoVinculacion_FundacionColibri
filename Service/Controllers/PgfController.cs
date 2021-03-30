using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebServiceFC.Modelos;
using WebServiceFC.IServicios;


namespace WebServiceFC.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class PgfController : ControllerBase

    {

        private readonly IPgfService pgfService;
        public PgfController(IPgfService pgf)
        {
            pgfService = pgf;
        }
        // GET: api/<PgfController>
        [HttpGet]
        [Route("[action]")]
        [Route("api/Pgf/GetPgf")]
        public IEnumerable<Pgf> GetPgf()
        {
            return pgfService.GetPgf();
        }
        // POST: api/<PgfController>
        [HttpPost]
        [Route("[action]")]
        [Route("api/Pgf/AddPgf")]
        public Pgf AddPgf(Pgf pgf)
        {
            return pgfService.AddPgf(pgf);
        }
        // PUT: api/<PgfController>
        [HttpPut]
        [Route("[action]")]
        [Route("api/Pgf/EditPgf")]
        public Pgf EditPgf(Pgf pgf)
        {
            return pgfService.UpdatePgf(pgf);
        }
        // DELETE: api/<PgfController>
        [HttpDelete]
        [Route("[action]")]
        [Route("api/Pgf/DeletePgf")]
        public Pgf DeletePgf(Guid idPgf)
        {
            return pgfService.DeletePgf(idPgf);
        }
        // GET_ByID: api/<PgfController>
        [HttpGet]
        [Route("[action]")]
        [Route("api/Pgf/GetPgfId")]
        public Pgf GetPgfById(Guid idPgf)
        {
            return pgfService.GetPgfById(idPgf);
        }
    }
}
