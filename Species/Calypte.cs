using System;

namespace Zoolandia.Species
{
    public class Calypte : Animal, IFlying, IHerbivore
    {
        public Calypte(string name, int height, int weight) : base(name, height, weight)
        {
            this.diet = "herbivore";
        }
        public virtual string hover()
        {
            return "Hovering over a flower";
        }
        public string fly()
        {
           return this.Name + " zips around flying in unpredictable patterns.";
        }
        public string land()
        {
            return "I've never seen a hummingbird at rest, so I assume they never land on anything and fly around until they die.";
        }
        public string graze()
        {
            return this.Name + " darts around some promising looking flowers, probing at the petals with its long beak.";
        }
        public string defend_against_predator(string predator)
        {
            return this.Name + " shoots around wildly to avoid the " + predator + "!";
        }
        public string defend_against_predator()
        {
            return this.Name + " flies around in a zigzag to get away!";
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