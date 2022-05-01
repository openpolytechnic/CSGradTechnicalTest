using OpenPolytechnic.Entity.Superheroes.Interfaces;

namespace OpenPolytechnic.Entity.Superheroes
{
    public class SuperheroEntity : ISuperheroEntity
    {
        public SuperheroEntity() {}

        public SuperheroEntity(
            string heroAlias,
            string realName,
            string powers,
            string catchphrase,
            string profileImageUrl)
        {
            HeroAlias = heroAlias;
            RealName = realName;
            Powers = powers;
            Catchphrase = catchphrase;
            ProfileImageUrl = profileImageUrl;
        }

        public string HeroAlias { get; internal set; }
        public string RealName { get; internal set; }
        public string Powers { get; internal set; }
        public string Catchphrase { get; internal set; }
        public string ProfileImageUrl { get; internal set; }
    }
}
