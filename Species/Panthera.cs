using System;

namespace Zoolandia.Species
{
    public class Panthera : Animal
    {
        public Panthera(string name, int height, int weight) : base(name, height, weight)
        {
        }
    }
    public class Tigris : Panthera
    {
        public Tigris(string name, int height, int weight) : base(name, height, weight)
        {
        }
    }       
}