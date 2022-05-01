using OpenPolytechnic.Entity.Superheroes.Interfaces;
using System.Collections.Generic;

namespace OpenPolytechnic.Entity.Superheroes.Marvel
{
    // This class exists so that databases are not required for the technical test
    // and should not be considered good code or practice.
    public static class MarvelHeroConstants
    {
        public static IEnumerable<ISuperheroEntity> AllMarvelHeroes = new List<ISuperheroEntity>
        {
            IronMan,
            CaptainAmerica,
            Hulk,
            BlackWidow,
            Wolverine,
            Jubilee,
            StarLord,
            Groot
        };

        public static ISuperheroEntity IronMan => new SuperheroEntity(
            "Iron Man",
            "Tony Stark",
            "Very cool armour; smart; rich",
            "I am Iron Man!",
            "iron_man.png");
        public static ISuperheroEntity CaptainAmerica => new SuperheroEntity(
            "Captain America",
            "Steve Rogers",
            "Enhanced strength and athleticism; nifty frisbee",
            "I can do this all day.",
            "cpt_america.png");
        public static ISuperheroEntity Hulk => new SuperheroEntity(
            "Hulk",
            "Bruce Banner",
            "Incredible size and strength; virtually indestructible; temper tantrums",
            "Hulk smash!",
            "hulk.png");
        public static ISuperheroEntity BlackWidow => new SuperheroEntity(
            "Black Widow",
            "Natasha Romanoff",
            "Fantastic athleticism and combat skills; stealthy",
            "To know the Black Widow is to die.",
            "black_widow.png");
        public static ISuperheroEntity SpiderMan => new SuperheroEntity(
            "Spider-Man",
            "Peter Parker",
            "Enhanced strength and altheticism; shoots sticky goo from wrists; quick wit",
            "Just your friendly neighbourhood Spider-Man!",
            "spidey.png");
        public static ISuperheroEntity Wolverine => new SuperheroEntity(
            "Wolverine",
            "Logan (formerly James Howlett)",
            "Ability to regenerate all physical damage to the point of immortality; metal skeleton; knives in hands",
            "Let's go, bub!",
            "wolverine.png");
        public static ISuperheroEntity Jubilee => new SuperheroEntity(
            "Jubilee",
            "Jubilation Lee",
            "Able to launch blinding fireworks from hands; snarky",
            "Does a mall babe eat chili fries?",
            "jubes.png");
        public static ISuperheroEntity StarLord => new SuperheroEntity(
            "Star-Lord",
            "Peter Quill",
            "Cosmic weapons; unbelievable luck; Walkman",
            "We're the Guardians of the Galaxy and we're here to-- #%@&!! We're too late, aren't we?",
            "star_lord.png");
        public static ISuperheroEntity Groot => new SuperheroEntity(
            "Groot",
            "Groot",
            "Tree-like body able to grow and extend at will; assumed botanical skills",
            "I am Groot!",
            "groot.png");
    }
}
