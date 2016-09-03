using System;

namespace Zoolandia.Species
{
    public class Vicugna : Animal, IAmbulatory, IHerbivore
    {
        public Vicugna(string name, int height, int weight) : base(name, height, weight)
        {
            this.diet = "herbivore";
        }

        public string defend_against_predator()
        {
            return run();
        }

        public string graze()
        {
            return this.Name + " munches on some plants.";
        }

        public string run()
        {
            return this.Name + " runs away!";
        }

        public string walk()
        {
            return this.Name + " lazily walks around.";
        }
    }
    public class Pacos : Vicugna
    {
        public Pacos(string name, int height, int weight) : base(name, height, weight)
        {
            this.commonName = "Alpaca";
            this.scientificName = "Vicugna Pacos";
        }
    }       
}