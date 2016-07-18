

namespace Zoolandia.Species
{
    public class AilurusFulgens : Animal 
    {
        //CONSTRUCTOR for red panda
        // base calls the base constructor
        public AilurusFulgens(string name, int height, int weight) : base(name, height, weight)
        { 
            //don't need to do anything additional for constructor
        }

        public AilurusFulgens(string name) : base(name)
        {
        }
        //use override to change the method functionality
        public override string Eat(int numberOfFoods)
        {
            string animalEat = base.Eat(3); //base calls parent method
            return animalEat + " nom nom nom";
        }
        public string Eat()
        {
            return "I don't know what I Just ate, but it was good";
        }
        public string Welcome (string name) 
        {
            this.Name = name;
            return Welcome();
        }

        public string Welcome()
        {
            return "Welcome, " + this.Name;
        }
        public override string Sound()
        {
            return "Cheee chee cheee";
        }
    }
}