using System;

namespace Zoolandia.Species
{
    public class Holicidae : Animal, IHerbivore
    {
        public Holicidae(string name, int height, int weight) : base(name, height, weight)
        {
            this.diet = "herbivore";
        }
        public string graze()
        {
            return "The " + this.commonName + " eats whatever snails eat.";
        }
        public string defend_against_predator()
        {
            return "the " + this.commonName + " retreats into its shell...";
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