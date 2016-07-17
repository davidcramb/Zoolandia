using System;

namespace Zoolandia.Species 
{
    public class IguanidaeIguana : Animal
    {
        public IguanidaeIguana(string name, int height, int weight) : base(name, height, weight) 
        {
        }
            public override string Eat(int numOfCrickets) 
            {
                return "I eat crickets and spinach leaves.";
            }
            public override string Sound()
            {
                return "Hiss?";
            }
    }
}