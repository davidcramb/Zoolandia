using System;

namespace Zoolandia.Species
{
    public class Lissemys : Animal
    {
        public Lissemys(string name, int height, int weight) : base(name, height, weight)
        {
        }
    }
    public class Punctata : Lissemys
    {
        public Punctata(string name, int height, int weight) : base(name, height, weight)
        {
        }
    }       
}