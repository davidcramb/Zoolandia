using System;

namespace Zoolandia.Species
{
    public class Bubo : Animal
    {
        public Bubo(string name, int height, int weight) : base(name, height, weight)
        {
        }
    public string makeNest()
        {
            return "Making a nest of twigs and owl leavings.";
        }
    }
    public class Scandiacus : Bubo
    {
        public Scandiacus(string name, int height, int weight) : base(name, height, weight)
        {
            this.commonName = "Snowy Owl";
            this.scientificName = "Bubo Scandiacus";
        }
        public string beEndangered()
        {
            return "Didn't mean to ruffle any feathers...";
        }
        public string beEnangengered(int numberOfOwls)
        {
            return "Dude stop there's only like " + numberOfOwls + " of us left in the world.";
        }
    }       
}