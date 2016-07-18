using System;

namespace Zoolandia.Species
{
    public class Desmodus : Animal
    {
        public Desmodus(string name, int height, int weight) : base(name, height, weight)
        {
        }
    }
    public class Rotundus : Desmodus
    {
        public Rotundus(string name, int height, int weight) : base(name, height, weight)
        {
        }
    }       
}