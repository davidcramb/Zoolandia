using System;

namespace Zoolandia.Species
{
    public class Crotalus : Animal
    {
        public Crotalus(string name, int height, int weight) : base(name, height, weight)
        {
        }
    public virtual string doStuff()
    {
        return "did some stuff";
    }
    }
    public class Adamanteus : Crotalus
    {
        public Adamanteus(string name, int height, int weight) : base(name, height, weight)
        {
            this.commonName = "Eastern Diamondback Rattlesnake";
            this.scientificName = "Crotalus Adamanteus";
        }
        public override string doStuff()
        {
            return "mischief managed.";
        }
    }       
}