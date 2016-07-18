using System;

namespace Zoolandia.Species
{
    public class Giraffa : Animal
    {
        public Giraffa(string name, int height, int weight) : base(name, height, weight)
        {
        }
    }
    public class Camelopardalis : Giraffa
    {
        public Camelopardalis(string name, int height, int weight) : base(name, height, weight)
        {
        }
    }       
}