using System;

namespace Zoolandia.Species
{
    public class Calypte : Animal
    {
        public Calypte(string name, int height, int weight) : base(name, height, weight)
        {
        }
    }
    public class Anna : Calypte
    {
        public Anna(string name, int height, int weight) : base(name, height, weight)
        {
        }
    }       
}