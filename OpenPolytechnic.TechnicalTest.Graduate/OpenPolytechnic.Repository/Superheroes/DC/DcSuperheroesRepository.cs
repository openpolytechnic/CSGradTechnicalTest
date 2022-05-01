using OpenPolytechnic.Entity.Superheroes.DC;
using OpenPolytechnic.Entity.Superheroes.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace OpenPolytechnic.Repository.Superheroes.DC
{
    public class DcSuperheroesRepository : IDcSuperheroesRepository
    {
        public IList<ISuperheroEntity> GetDcHeroes()
        {
            return DcHeroConstants.AllDcHeroes.ToList();
        }
    }
}
