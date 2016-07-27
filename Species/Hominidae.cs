using System;

namespace Zoolandia.Species
{
    public class Hominidae : Animal
    {
        public Hominidae(string name, int height, int weight) : base(name, height, weight)
        {
            this.diet = "omnivore";
        }
    }
    public class Gorilla : Hominidae
    {
        public Gorilla(string name, int height, int weight) : base(name, height, weight)
        {
            this.commonName = "Gorilla";
            this.scientificName = "Hominidae Gorilla";
        }
    }       
}