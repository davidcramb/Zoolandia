using System;

namespace Zoolandia.Species 
{
    public class SuricataSuricatta : Animal 
    {
        public SuricataSuricatta(string name, int height, int weight) : base(name, height, weight)
        {
        }
        public override string Sound()
        {
            string animalSound = base.Sound();
            return "Scamper scamper scamper";
        }
        public override string MatingDance()
        {
            string animalMatingDance = base.MatingDance();
            return "Cover your eyes, Billy.";
        }
    }   
}