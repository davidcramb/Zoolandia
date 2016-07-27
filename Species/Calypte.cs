using System;

namespace Zoolandia.Species
{
    public class Calypte : Animal
    {
        public Calypte(string name, int height, int weight) : base(name, height, weight)
        {
            this.diet = "herbivore";
        }
        public virtual string hover()
        {
            return "Hovering over a flower";
        }
    }
    public class Anna : Calypte
    {
        public Anna(string name, int height, int weight) : base(name, height, weight)
        {
            this.commonName = "Anna's Hummingbird";
            this.scientificName = "Calypte Anna";
        }
        public override string hover()
        {
            return "Hover hover hover hover";
        }
    }       
}