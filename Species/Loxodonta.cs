using System;

namespace Zoolandia.Species
{
    public class Loxodonta : Animal, IAmbulatory, IHerbivore
    {
        public Loxodonta(string name, int height, int weight) : base(name, height, weight)
        {
            this.diet = "Herbivore";
        }

        public string defend_against_predator()
        {
            return this.Name + " stomps the ground and charges!";
        }
        public string defend_against_predator(int numOfElephants)
        {
            return this.Name + " brings " + numOfElephants + " friends along for protection. Don't bring a knife to a tusk fight.";
        }

        public string graze()
        {
            return this.Name + " eats a lot of grass. A lot.";
        }

        public string run()
        {
            return "The ground shakes as " + this.Name + " runs along the ground!";
        }

        public string walk()
        {
            return "Make way for Prince Ali.";
        }
    }
    public class Africana : Loxodonta
    {
        public Africana(string name, int height, int weight) : base(name, height, weight)
        {
            this.commonName = "African Bush Elephant";
            this.scientificName = "Loxodonta Africana";
        }
    }       
}