using System;

namespace Zoolandia.Species
{
    public class Alcelaphinae : Animal
    {
        public Alcelaphinae(string name, int height, int weight) : base(name, height, weight)
        {
        }
    }
    public class Connochaetes : Alcelaphinae
    {
        public Connochaetes(string name, int height, int weight) : base(name, height, weight)
        {
        }
    }       
}