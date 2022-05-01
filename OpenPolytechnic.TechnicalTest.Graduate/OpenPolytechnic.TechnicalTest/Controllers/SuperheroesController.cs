using Microsoft.AspNetCore.Mvc;
using OpenPolytechnic.Business.Superheroes.Marvel.Interfaces;
using OpenPolytechnic.DataContract.Superheroes;
using System.Collections.Generic;

namespace OpenPolytechnic.TechnicalTest.Controllers
{
    [ApiController]
    [Route("api/superheroes")]
    public class SuperheroesController
    {
        private readonly IMarvelSuperheroesService marvelSuperheroesService;

        public SuperheroesController(IMarvelSuperheroesService marvelSuperheroesService)
        {
            this.marvelSuperheroesService = marvelSuperheroesService;
        }

        [Route("marvel")]
        [HttpGet]
        public IEnumerable<SuperheroDataContract> GetMarvelSuperheroes()
        {
            return marvelSuperheroesService.GetMarvelSuperheroes();
        }
    }
}
