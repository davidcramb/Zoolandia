using System;

namespace Zoolandia.Species
{
    public class Macropus : Animal
    {
        public Macropus(string name, int height, int weight) : base(name, height, weight)
        {
        }
    }
    public class Giganteus : Macropus
    {
        public Giganteus(string name, int height, int weight) : base(name, height, weight)
        {
        }
    }       
}