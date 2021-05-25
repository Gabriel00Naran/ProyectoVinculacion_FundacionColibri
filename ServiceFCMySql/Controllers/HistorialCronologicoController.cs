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
        public IEnumerable<Historialcronologico> GetHistorialCronologico()
        {
            return historialService.GetHistorialCronologico();
        }
        // POST: api/<HistorialCronologicoController>
        [HttpPost]
        [Route("[action]")]
        [Route("api/HistorialCronologico/AddHistorialCronologico")]
        public Historialcronologico AddHistorialCronologico(Historialcronologico historial)
        {
            return historialService.AddHistorialCronologico(historial);
        }
        // PUT: api/<HistorialCronologicoController>
        [HttpPut]
        [Route("[action]")]
        [Route("api/HistorialCronologico/EditHistorialCronologico")]
        public Historialcronologico EditHistorialCronologico(Historialcronologico historial)
        {
            return historialService.UpdateHistorialCronologico(historial);
        }
        // DELETE: api/<HistorialCronologicoController>
        [HttpDelete]
        [Route("[action]")]
        [Route("api/HistorialCronologico/DeleteHistorialCronologico")]
        public Historialcronologico DeleteHistorialCronologico(int idHistorial)
        {
            return historialService.DeleteHistorialCronologico(idHistorial);
        }
        // GET_ByID: api/<HistorialCronologicoController>
        [HttpGet]
        [Route("[action]")]
        [Route("api/HistorialCronologico/GetHistorialCronologicoId")]
        public Historialcronologico GetHistorialCronologicoById(int idHistorial)
        {
            return historialService.GetHistorialCronologicoById(idHistorial);
        }

         [HttpGet]
        [Route("[action]")]
        [Route("api/HistorialCronologico/GetHistorialCronologicoIdPersona")]
        public List<Historialcronologico> GetHistorialCronologicoByIdPersona(int idpersona)
        {
            return historialService.GetHistorialCronologicoByIdPersona(idpersona);
        }


    }
}
