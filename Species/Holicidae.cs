using System;

namespace Zoolandia.Species
{
    public class Holicidae : Animal
    {
        public Holicidae(string name, int height, int weight) : base(name, height, weight)
        {
        }
    }
    public class Helix : Holicidae
    {
        public Helix(string name, int height, int weight) : base(name, height, weight)
        {
        }
    }       
}