using OpenPolytechnic.Business.Superheroes.Marvel.Interfaces;
using OpenPolytechnic.DataContract.Superheroes;
using OpenPolytechnic.Entity.Superheroes.Interfaces;
using OpenPolytechnic.Repository.Superheroes.Marvel.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace OpenPolytechnic.Business.Superheroes.Marvel
{
    public class MarvelSuperheroesService : IMarvelSuperheroesService
    {
        private readonly IMarvelSuperheroesRepository superheroesRepository;

        public MarvelSuperheroesService(IMarvelSuperheroesRepository superheroesRepository)
        {
            this.superheroesRepository = superheroesRepository;
        }

        public IEnumerable<SuperheroDataContract> GetMarvelSuperheroes()
        {
            return superheroesRepository.GetMarvelSuperHeroes().Select(MapToDataContract);
        }

        private SuperheroDataContract MapToDataContract(ISuperheroEntity entity)
        {
            return new SuperheroDataContract
            {
                HeroAlias = entity.HeroAlias,
                RealName = entity.RealName,
                Powers = entity.Powers,
                Catchphrase = entity.Catchphrase,
                ProfileImageUrl = entity.ProfileImageUrl
            };
        }
    }
}
