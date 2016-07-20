using System;

namespace Zoolandia.Species
{
    public class Buceros : Animal
    {
        public Buceros(string name, int height, int weight) : base(name, height, weight)
        {
        }
    }
    public class Bicornis : Buceros
    {
        public Bicornis(string name, int height, int weight) : base(name, height, weight)
        {
            this.commonName = "Great Hornbill";
            this.scientificName = "Buceros Bicornis";
        }
    }       
}