

namespace Zoolandia.Species
{
    public class Struthio : Animal
    {
        public Struthio(string name, int height, int weight) : base (name, height, weight) 
        {
            this.diet = "herbivore";
        }
        public Struthio(string name) : base (name)
        {
        }
        
        private string StickHeadInSand(int days)
        {
            return "Let me know when this all blows over...should be about " + days + " days.";
        }
        public string Hide(int days)
        {
            return StickHeadInSand(days);
        }
        public override string Sound()
        {
            string animalSound = base.Sound();
            return "Waaark!";
        }
        public override string MatingDance()
        {
            return "The ostrich does a giant chicken dance like you see at wedding receptions.";
        }
    }
    public class Camelus : Struthio 
    {
        public Camelus(string name, int height, int weight) : base(name, height, weight)
        {
            this.commonName = "Ostrich";
            this.scientificName = "Struthio Camelus";
        }
    }
}