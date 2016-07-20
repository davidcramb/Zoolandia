

namespace Zoolandia.Species 
{
    public class IguanidaeIguana : Animal
    {
        public IguanidaeIguana(string name, int height, int weight) : base(name, height, weight) 
        {
        } 

        public IguanidaeIguana(string name) : base(name)
        {
        }  
        public override string Eat(int numOfCrickets) 
        {
            return "this.Name ate " + numOfCrickets + " crickets and spinach leaves.";
        }
        public override string Sound()
        {
            string animalSound = base.Sound();
            return "Hiss?";
        }
        public override string MatingDance()
        {
            return this.Name + " side steps around and raises its tail.";
        }
}
}