

using System;

namespace Zoolandia.Species
{
    public class Octopus : Animal, IAquatic
    {
        public Octopus(string name, int height, int weight) : base (name, height, weight)
        {
            this.diet = "omnivore";
        }
        
        public Octopus(string name) : base(name)
        {
        }
        public string pushHeavyWeight(int minutes) 
        {
            return "Oof! This weight is heavy! It will take me " + minutes + " minutes to push it off!";
        }
        public string pushHeavyWeight()
        {
            return "Huff...it's too heavy...";
        }
        public override string MatingDance()
        {
            return "Hey! Don't tease the octopus, kids!";
        }
        public override string Sound()
        {
            string animalSound = base.Sound();
            return "Blub blub blub";
        }

        public string swim()
        {
            return this.Name + " propels itself forward through the water.";
        }

        public string dive()
        {
            return this.Name + " returns to the seabed.";
        }

        public string surface()
        {
            return null;
        }
    }
    public class Vulgaris : Octopus 
    {
        public Vulgaris(string name, int height, int weight) : base (name, height, weight)
        {
            this.commonName = "Octopus";
            this.scientificName = "Octopus Vulgaris";
            this.isCute = false;
        }
    }
}