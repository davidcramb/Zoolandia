

namespace Zoolandia.Species 
{
    public class Suricata : Animal 
    {
        public Suricata(string name, int height, int weight) : base(name, height, weight)
        {
        }
        public Suricata(string name) : base(name)
        {
            this.diet = "omnivore";
        }
        public override string Sound()
        {
            string animalSound = base.Sound();
            return "Scamper scamper scamper";
        }

        public string Sound(string warning, int minutes)
        {
            string animalSound = base.Sound();
            return "The meerkats are startled! There's a " + warning + " predator that has been prowling around for " + minutes + " minutes...";
        }
        public override string MatingDance()
        {
            string animalMatingDance = base.MatingDance();
            return "Cover your eyes, Billy.";
        }
    }
    public class Suricatta : Suricata
    {
        public Suricatta(string name, int height, int weight) : base (name, height, weight)
        {
            this.commonName = "Meerkat";
            this.scientificName = "Suricata Suricatta";
            this.isCute = true;
        }
    }
}