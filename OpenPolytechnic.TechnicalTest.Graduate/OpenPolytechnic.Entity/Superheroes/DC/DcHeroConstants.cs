using OpenPolytechnic.Entity.Superheroes.Interfaces;
using System.Collections.Generic;

namespace OpenPolytechnic.Entity.Superheroes.DC
{
    // This class exists so that databases are not required for the technical test
    // and should not be considered good code or practice.
    public static class DcHeroConstants
    {
        public static IEnumerable<ISuperheroEntity> AllDcHeroes = new List<ISuperheroEntity>
        {
            Batman,
            Superman,
            Flash,
            WonderWoman,
            Raven,
            Starfire,
            GreenLantern,
            Katana
        };

        public static ISuperheroEntity Batman => new SuperheroEntity(
            "Batman",
            "Bruce Wayne",
            "Exceptional martial arts skills; crazy smart; stealthy; brooding",
            "I'm Batman!",
            "bats.png");
        public static ISuperheroEntity Superman => new SuperheroEntity(
            "Superman",
            "Kal-El (also goes by Clark Kent)",
            "Basically a god if Kryptonite isn't around",
            "Truth, justic, and a better tomorrow!",
            "supes.png");
        public static ISuperheroEntity Flash => new SuperheroEntity(
            "The Flash",
            "Barry Allen",
            "Fast... like really, really fast",
            "I'm the fastest man alive!",
            "flash.png");
        public static ISuperheroEntity WonderWoman => new SuperheroEntity(
            "Wonder Woman",
            "Diana Prince",
            "Amazonian combat skills; lasso that compels the truth; invisible plane (however that works)",
            "So long as there is hope, there can be victory!",
            "wonder_woman.png");
        public static ISuperheroEntity Raven => new SuperheroEntity(
            "Raven",
            "Rachel Roth",
            "Soul projection; empathy; stoicism and sullenness",
            "Can we go now?",
            "raven.png");
        public static ISuperheroEntity Starfire => new SuperheroEntity(
            "Starfire",
            "Koriand'r",
            "Alien zap zap stuff; healing factor",
            "I will not let despair dim my flame!",
            "starfire.png");
        public static ISuperheroEntity GreenLantern => new SuperheroEntity(
            "Green Lantern",
            "Hal Jordan",
            "Cosmic jewellry",
            "In brightest day, in blackest night, no evil shall escape my sight!",
            "green_lantern.png");
        public static ISuperheroEntity Katana => new SuperheroEntity(
            "Katana",
            "Tatsu Yamashiro",
            "Master swordsman; has a scary sword that drinks the souls of people",
            "For him, I weep.",
            "katana.png");
    }
}
