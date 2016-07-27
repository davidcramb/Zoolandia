using System;

namespace Zoolandia.Species
{
    public class Vicugna : Animal
    {
        public Vicugna(string name, int height, int weight) : base(name, height, weight)
        {
            this.diet = "herbivore";
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