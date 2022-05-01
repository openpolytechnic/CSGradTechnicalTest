using System.Runtime.Serialization;

namespace OpenPolytechnic.DataContract.Superheroes
{
    [DataContract]
    public class SuperheroDataContract
    {
        [DataMember]
        public string HeroAlias { get; set; }
        [DataMember]
        public string RealName { get; set; }
        [DataMember]
        public string Powers { get; set; }
        [DataMember]
        public string Catchphrase { get; set; }
        [DataMember]
        public string ProfileImageUrl { get; set; }
    }
}
