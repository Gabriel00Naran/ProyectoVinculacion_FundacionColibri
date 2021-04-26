using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebServiceFCMySql.IServicios;
using WebServiceFCMySql.Modelos;


namespace WebServiceFC.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class GeneroController : ControllerBase

    {

        private readonly IGeneroService generoService;
        public GeneroController(IGeneroService genero)
        {
            generoService = genero;
        }
        // GET: api/<GeneroController>
        [HttpGet]
        [Route("[action]")]
        [Route("api/Genero/GetGenero")]
        public IEnumerable<Genero> GetGenero()
        {
            return generoService.GetGenero();
        }
        // POST: api/<GeneroController>
        [HttpPost]
        [Route("[action]")]
        [Route("api/Genero/AddGenero")]
        public Genero AddGenero(Genero genero)
        {
            return generoService.AddGenero(genero);
        }
        // PUT: api/<GeneroController>
        [HttpPut]
        [Route("[action]")]
        [Route("api/Genero/EditGenero")]
        public Genero EditGenero(Genero genero)
        {
            return generoService.UpdateGenero(genero);
        }
        // DELETE: api/<GeneroController>
        [HttpDelete]
        [Route("[action]")]
        [Route("api/Genero/DeleteGenero")]
        public Genero DeleteGenero(int idGenero)
        {
            return generoService.DeleteGenero(idGenero);
        }
        // GET_ByID: api/<GeneroController>
        [HttpGet]
        [Route("[action]")]
        [Route("api/Genero/GetGeneroId")]
        public Genero GetGeneroById(int idGenero)
        {
            return generoService.GetGeneroById(idGenero);
        }
    }
}
