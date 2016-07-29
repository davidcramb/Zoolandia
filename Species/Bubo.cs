using System;

namespace Zoolandia.Species
{
    public class Bubo : Animal, IFlying, IPredator
    {
        public Bubo(string name, int height, int weight) : base(name, height, weight)
        {
            this.diet = "carnivore";
        }
    public string makeNest()
        {
            return "Making a nest of twigs and owl leavings.";
        }
        public string fly()
        {
            return this.Name + " takes to the skies!";
        }
        public string land()
        {
            return this.Name + " lands on a treebranch.";
        }
        public string bite()
        {
            return this.Name + " tears at its prey with its sharp beak.";
        }
        public string hunt(string prey)
        {
            return bite() + " " + claw() + "The " + this.commonName + " returns to its nest with its prized " + prey + ".";
        }
        public string claw()
        {
            return this.Name + " wrenches at its prey with sharp talons.";
        }
        public string stalk()
        {
            return null;
        }
        public string hunt()
        {
            return this.Name + " is on the lookout for a meal.";
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