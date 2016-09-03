using System;

namespace Zoolandia.Species
{
    public class Crotalus : Animal, IReptile, IPredator, IAmbulatory
    {
        public Crotalus(string name, int height, int weight) : base(name, height, weight)
        {
            this.diet = "carnivore";
        }
        public virtual string doStuff()
        {
            return "did some stuff";
        }
        public string walk()
        {
            return "Ssslither ssslither ssslither";
        }    
        public string run()
        {
            return "Ssslither fassster!";
        }
        public string hunt()
        {
            return "The " + this.commonName + " tastes the air by flickering out its tongue and slithers in the direction of something to eat.";
        }
        public string claw()
        {
            return null;
        }
        public string bite()
        {
            return this.Name + " unhinges his jaw which looks kind of gross and wraps his entire head around its prey.";
        }
        public string stalk()
        {
            return this.Name + " silently slithers stealthily towards its target.";
        }
        public string get_warm()
        {
            return "Getting on a hot sun baked rock.";
        }
        public string lay_eggs()
        {
            return "Assuming this thing is a female, she lays some eggs in the sand.";
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