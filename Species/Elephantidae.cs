using System;

namespace Zoolandia.Species
{
    public class Elephantidae : Animal
    {
        public Elephantidae(string name, int height, int weight) : base(name, height, weight)
        {
        }
    }
    public class Loxodonta : Elephantidae
    {
        public Loxodonta(string name, int height, int weight) : base(name, height, weight)
        {
        }
    }       
}