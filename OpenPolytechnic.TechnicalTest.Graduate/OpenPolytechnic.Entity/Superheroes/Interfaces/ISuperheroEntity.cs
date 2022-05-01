namespace OpenPolytechnic.Entity.Superheroes.Interfaces
{
    public interface ISuperheroEntity
    {
        public string HeroAlias { get; }
        public string RealName { get; }
        public string Powers { get; }
        public string Catchphrase { get; }
        public string ProfileImageUrl { get; }
    }
}
