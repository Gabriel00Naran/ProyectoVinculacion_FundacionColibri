using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebServiceFC.Modelos;
using WebServiceFC.IServicios;


namespace WebServiceFC.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class HistorialCronologicoController : ControllerBase

    {

        private readonly IHistorialCronologicoService historialService;
        public HistorialCronologicoController(IHistorialCronologicoService historial)
        {
            historialService = historial;
        }
        // GET: api/<HistorialCronologicoController>
        [HttpGet]
        [Route("[action]")]
        [Route("api/HistorialCronologico/GetHistorialCronologico")]
        public IEnumerable<HistorialCronologico> GetHistorialCronologico()
        {
            return historialService.GetHistorialCronologico();
        }
        // POST: api/<HistorialCronologicoController>
        [HttpPost]
        [Route("[action]")]
        [Route("api/HistorialCronologico/AddHistorialCronologico")]
        public HistorialCronologico AddHistorialCronologico(HistorialCronologico historial)
        {
            return historialService.AddHistorialCronologico(historial);
        }
        // PUT: api/<HistorialCronologicoController>
        [HttpPut]
        [Route("[action]")]
        [Route("api/HistorialCronologico/EditHistorialCronologico")]
        public HistorialCronologico EditHistorialCronologico(HistorialCronologico historial)
        {
            return historialService.UpdateHistorialCronologico(historial);
        }
        // DELETE: api/<HistorialCronologicoController>
        [HttpDelete]
        [Route("[action]")]
        [Route("api/HistorialCronologico/DeleteHistorialCronologico")]
        public HistorialCronologico DeleteHistorialCronologico(Guid idHistorial)
        {
            return historialService.DeleteHistorialCronologico(idHistorial);
        }
        // GET_ByID: api/<HistorialCronologicoController>
        [HttpGet]
        [Route("[action]")]
        [Route("api/HistorialCronologico/GetHistorialCronologicoId")]
        public HistorialCronologico GetHistorialCronologicoById(Guid idHistorial)
        {
            return historialService.GetHistorialCronologicoById(idHistorial);
        }
          // GET_ByID: api/<HistorialCronologicoController>
        [HttpGet]
        [Route("[action]")]
        [Route("api/HistorialCronologico/GetHistorialCronologicoIdPersona")]
        public HistorialCronologico GetHistorialCronologicoByIdPersona(Guid IdPersona)
        {
            return historialService.GetHistorialCronologicoByIdPersona(IdPersona);
        }
    }
}
