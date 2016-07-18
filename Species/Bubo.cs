using System;

namespace Zoolandia.Species
{
    public class Bubo : Animal
    {
        public Bubo(string name, int height, int weight) : base(name, height, weight)
        {
        }
    }
    public class Scandiacus : Bubo
    {
        public Scandiacus(string name, int height, int weight) : base(name, height, weight)
        {
        }
    }       
}