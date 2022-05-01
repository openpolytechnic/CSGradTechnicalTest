using OpenPolytechnic.Entity.Superheroes.Interfaces;
using OpenPolytechnic.Entity.Superheroes.Marvel;
using OpenPolytechnic.Repository.Superheroes.Marvel.Interfaces;
using System.Collections.Generic;

namespace OpenPolytechnic.Repository.Superheroes.Marvel
{
    public class MarvelSuperheroesRepository : IMarvelSuperheroesRepository
    {
        public MarvelSuperheroesRepository()
        {

        }

        public IEnumerable<ISuperheroEntity> GetMarvelSuperHeroes()
        {
            return MarvelHeroConstants.AllMarvelHeroes;
        }
    }
}
