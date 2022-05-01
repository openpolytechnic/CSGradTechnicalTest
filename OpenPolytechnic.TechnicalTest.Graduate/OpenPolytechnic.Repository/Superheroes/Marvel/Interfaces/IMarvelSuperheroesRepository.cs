using OpenPolytechnic.Entity.Superheroes.Interfaces;
using System.Collections.Generic;

namespace OpenPolytechnic.Repository.Superheroes.Marvel.Interfaces
{
    public interface IMarvelSuperheroesRepository
    {
        public IEnumerable<ISuperheroEntity> GetMarvelSuperHeroes();
    }
}
