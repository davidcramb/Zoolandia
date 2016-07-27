

namespace Zoolandia.Species 
{
    public class Iguanidae : Animal
    {
        public Iguanidae(string name, int height, int weight) : base(name, height, weight) 
        {
            this.diet = "omnivore";
        } 

        public Iguanidae(string name) : base(name)
        {
        }  
        public override string Eat(int numOfCrickets) 
        {
            return this.Name + " ate " + numOfCrickets + " crickets and spinach leaves.";
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
    public class Iguana : Iguanidae
    {
        public Iguana(string name, int height, int weight) : base (name, height, weight)
        {
            this.commonName = "Green Iguana";
            this.scientificName = "Iguanidae Iguana";
            this.isCute = true;
        }
    }
}