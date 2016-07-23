using System;

namespace Zoolandia.Species
{
    public class Aptenodytes : Animal
    {
        public Aptenodytes(string name, int height, int weight) : base(name, height, weight)
        {
        }
        public virtual string waddle()
        {
            return "Waddle waddle waddle";
        }
    }
    public class Forsteri : Aptenodytes
    {
        public Forsteri(string name, int height, int weight) : base(name, height, weight)
        {
            this.commonName = "Emperor Penguin";
            this.scientificName = "Aptenodytes Forsteri";
        }
        public override string waddle()
        {
            return "The " + this.commonName + " waddles around looking pretty dang spiffy.";
        }
        public string dive()
        {
            return "Diving for a fish";
        }
        public string dive (int numOfFish)
        {
            return "The " + this.commonName + " dives into the water looking for " + numOfFish + " fish.";
        }
    }       
}