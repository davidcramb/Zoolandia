using System;

namespace Zoolandia.Species
{
    public class Buceros : Animal, IFlying, IPredator
    {
        public Buceros(string name, int height, int weight) : base(name, height, weight)
        {
            this.diet = "carnivore";
        }
        public string preen()
        {
            return this.Name + " secretes a nasty fluid and spreads it to its beak and feathers.";
        }
        public string fly()
        {
            return this.commonName + " flies! Flies! FLIES!";
        }
        public string land()
        {
            return this.commonName + " lands! Lands! LANDS!!";
        }
        public string hunt()
        {
            return this.commonName + " circles around in the air looking for a meal.";
        }
        public string claw()
        {
            return this.commonName + " scratches at is prey trying to grasp it in its talons.";
        }
        public string stalk()
        {
            return null;
        }
        public string bite()
        {
            return this.commonName + " bites. Clomp clomp.";
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