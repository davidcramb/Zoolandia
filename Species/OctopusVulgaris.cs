using System;

namespace Zoolandia.Species
{
    public class OctopusVulgaris : Animal
    {
        public OctopusVulgaris(string name, int height, int weight) : base (name, height, weight)
        {
        }

        public string pushHeavyWeight(int minutes) 
        {
            return "Oof! This weight is heavy! It will take me " + minutes + " minutes to push it off!";
        }
    }
}