using OpenPolytechnic.DataContract.Superheroes;
using System.Collections.Generic;

namespace OpenPolytechnic.Business.Superheroes.Marvel.Interfaces
{
    public interface IMarvelSuperheroesService
    {
        public IEnumerable<SuperheroDataContract> GetMarvelSuperheroes();
    }
}
