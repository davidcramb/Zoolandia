using System;

namespace Zoolandia.Species
{
    public class Giraffa : Animal
    {
        public Giraffa(string name, int height, int weight) : base(name, height, weight)
        {
        }
        public string stretch()
        {
            return this.Name + " stretches for leaves on a tree.";
        }
        public string stretch (int inches)
        {
            return this.Name + " pushes it to the limit and stretches " + inches + " inches higher for more leaves.";
        }
    }
    public class Camelopardalis : Giraffa
    {
        public Camelopardalis(string name, int height, int weight) : base(name, height, weight)
        {
        }
    }       
}