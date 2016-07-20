using System;

namespace Zoolandia.Species
{
    public class Loxodonta : Animal
    {
        public Loxodonta(string name, int height, int weight) : base(name, height, weight)
        {
        }
    }
    public class Africana : Loxodonta
    {
        public Africana(string name, int height, int weight) : base(name, height, weight)
        {
            this.commonName = "African Bush Elephant";
            this.scientificName = "Loxodonta Africana";
        }
    }       
}