using System;

namespace Zoolandia.Species
{
    public class Aptenodytes : Animal, IPredator, IAmbulatory, IAquatic
    {
        public Aptenodytes(string name, int height, int weight) : base(name, height, weight)
        {
            this.diet = "carnivore";
        }
        public virtual string waddle()
        {
            return "Waddle waddle waddle";
        }
        public string bite()
        {
            return "It chomps on a fish.";
        }
        public string claw()
        {
            return "Penguins don't have claws so it flaps uselessly at its foe.";
        }
        public string stalk()
        {
            return "It swims near a school of stupid fish.";
        }
        public string hunt()
        {
            return stalk();
        }
        public string walk()
        {
            return "Penguin waddles.";
        }
        public string run()
        {
            return "Penguin waddles fast!";
        }
        public string swim()
        {
            return "Penguin glides gracefully in the water.";
        }
        public string dive()
        {
            return "Penguin dives into the water with minimal splash.";
        }
        public string surface()
        {
            return "The penguin breaches the event horizon of the water and returns to the surface.";
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