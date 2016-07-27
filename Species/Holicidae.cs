using System;

namespace Zoolandia.Species
{
    public class Holicidae : Animal
    {
        public Holicidae(string name, int height, int weight) : base(name, height, weight)
        {
            this.diet = "herbivore";
        }
    }
    public class Helix : Holicidae
    {
        public Helix(string name, int height, int weight) : base(name, height, weight)
        {
            this.commonName = "Snail";
            this.scientificName = "Holicidae Helix";
        }
    }       
}