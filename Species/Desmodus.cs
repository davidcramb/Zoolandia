using System;

namespace Zoolandia.Species
{
    public class Desmodus : Animal
    {
        public Desmodus(string name, int height, int weight) : base(name, height, weight)
        {
            this.diet = "carnivore";
        }
        public virtual string fly()
        {
            return "I am the terror that flaps in the night.";
        }
        public string sonar()
        {
            return "skree! skree! skree!";
        }
    }
    public class Rotundus : Desmodus
    {
        public Rotundus(string name, int height, int weight) : base(name, height, weight)
        {
            this.commonName = "Vampire Bat";
            this.scientificName = "Desmodus Rotundus";
        }
        public string drainBlood()
        {
            return "Aieeeee!";
        }
    }       
}