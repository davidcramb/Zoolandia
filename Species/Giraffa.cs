using System;

namespace Zoolandia.Species
{
    public class Giraffa : Animal, IHerbivore, IAmbulatory
    {
        public Giraffa(string name, int height, int weight) : base(name, height, weight)
        {
            this.diet = "herbivore";
        }
        public string stretch()
        {
            return this.Name + " stretches for leaves on a tree.";
        }
        public string stretch (int inches)
        {
            return this.Name + " pushes it to the limit and stretches " + inches + " inches higher for more leaves.";
        }
        public string walk()
        {
            return "walking...";
        }
        public string run()
        {
            return "runs quickly!";
        }
        public string graze()
        {
            return "Reaching for that topmost leaf.";
        }
        public string defend_against_predator()
        {
            return null;
        }
        public string defend_against_predator(string predator)
        {
            if (predator != "lion")
            {
                return null;
            }
            else
            {
                return this.Name + " tries to kick the " + predator + " and " + run();
            }
        }
    }
    public class Camelopardalis : Giraffa
    {
        public Camelopardalis(string name, int height, int weight) : base(name, height, weight)
        {
        }
    }       
}