

namespace Zoolandia.Species
{
    public class Ailurus : Animal , IAmbulatory
    {
        //CONSTRUCTOR for red panda
        // base calls the base constructor
        public Ailurus(string name, int height, int weight) : base(name, height, weight)
        { 
            //don't need to do anything additional for constructor
        }

        public Ailurus(string name) : base(name)
        {
            this.diet = "omnivore";
        }

        //use override to change the method functionality
        public override string Eat(int numberOfFoods)
        {
            string animalEat = base.Eat(3); //base calls parent method
            return animalEat + " nom nom nom";
        }
        public virtual string Eat(int numberOfFoods, string omnivore)
        {
            return "I don't know what I Just ate, but it was good";
        }
        public override string Sound()
        {
            return "Cheee chee cheee";
        }
        public string walk()
        {
            return this + " walks around on all fours.";
        }
        public string run()
        {
            return this + " runs away quickly!";
        }

    }
    public class Fulgens : Ailurus
    {
        public Fulgens(string name, int height, int weight) : base (name, height, weight)
        {
            this.commonName = "Red Panda";
            this.scientificName = "Ailurus Fulgens";
            this.isCute = true;
        }
    }
}