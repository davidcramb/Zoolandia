using System;

namespace Zoolandia.Species
{
    public class Hominidae : Animal
    {
        public Hominidae(string name, int height, int weight) : base(name, height, weight)
        {
        }
    }
    public class Gorilla : Hominidae
    {
        public Gorilla(string name, int height, int weight) : base(name, height, weight)
        {
        }
    }       
}