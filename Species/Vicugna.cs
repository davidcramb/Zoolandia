using System;

namespace Zoolandia.Species
{
    public class Vicugna : Animal
    {
        public Vicugna(string name, int height, int weight) : base(name, height, weight)
        {
        }
    }
    public class Pacos : Vicugna
    {
        public Pacos(string name, int height, int weight) : base(name, height, weight)
        {
        }
    }       
}