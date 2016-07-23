using System;

namespace Zoolandia.Species
{
    public class Buceros : Animal
    {
        public Buceros(string name, int height, int weight) : base(name, height, weight)
        {
        }
        public string preen()
        {
            return this.Name + " secretes a nasty fluid and spreads it to its beak and feathers.";
        }
    }
    public class Bicornis : Buceros
    {
        public Bicornis(string name, int height, int weight) : base(name, height, weight)
        {
            this.commonName = "Great Hornbill";
            this.scientificName = "Buceros Bicornis";
        }
        public string airDuel(int numOfBirds)
        {
            return numOfBirds + " hornbills take flight and start fighting in the air with their beaks.";
        }
    }       
}