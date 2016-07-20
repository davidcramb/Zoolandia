using System;

namespace Zoolandia.Species
{
    public class Panthera : Animal
    {
        public Panthera(string name, int height, int weight) : base(name, height, weight)
        {
        }   
        public string meow ()
        {
            return "meow";
        }
        public virtual string hunt_prey(int numberOfPrey)
        {
            return "Cats are balls of fluff with razors for feet.";
        }
    }
    public class Tigris : Panthera
    {
        public Tigris(string name, int height, int weight) : base(name, height, weight)
        {
            this.commonName = "Tiger";
            this.scientificName = "Panthera Tigris";
        }
        public override string hunt_prey(int numberOfPrey)
        {
            return this.commonName + " begins stalking " + numberOfPrey + " delicious animals around...";
        }
    }       
}