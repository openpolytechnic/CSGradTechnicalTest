using OpenPolytechnic.Entity.Superheroes.Interfaces;
using System.Collections.Generic;

namespace OpenPolytechnic.Repository.Superheroes.DC
{
    public interface IDcSuperheroesRepository
    {
        public IList<ISuperheroEntity> GetDcHeroes();
    }
}
