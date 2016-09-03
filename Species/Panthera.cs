using System;

namespace Zoolandia.Species
{
    public class Panthera : Animal, IAmbulatory, IPredator
    {
        public Panthera(string name, int height, int weight) : base(name, height, weight)
        {
            this.diet = "carnivore";
        }   
        public string meow ()
        {
            return "meow";
        }
        public virtual string hunt_prey(int numberOfPrey)
        {
            return "Cats are balls of fluff with razors for feet.";
        }

        public string walk()
        {
            return this.Name + " saunters around nobly.";
        }

        public string run()
        {
            return this.Name + " breaks into a fast run.";
        }

        public string hunt()
        {
            return null;
        }
        public string hunt(string prey)
        {
            return this.Name + " searches for a " + prey + "."; 
        }

        public string bite()
        {
            return "Gnash!";
        }

        public string claw()
        {
            return "Swipe!";
        }

        public string stalk()
        {
            return this.Name + " quitly stalks its prey...";
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