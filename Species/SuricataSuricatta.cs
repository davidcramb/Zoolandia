

namespace Zoolandia.Species 
{
    public class SuricataSuricatta : Animal 
    {
        public SuricataSuricatta(string name, int height, int weight) : base(name, height, weight)
        {
        }
        public SuricataSuricatta(string name) : base(name)
        {
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
}