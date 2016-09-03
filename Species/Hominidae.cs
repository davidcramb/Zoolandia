using System;

namespace Zoolandia.Species
{
    public class Hominidae : Animal, IAmbulatory
    {
        public Hominidae(string name, int height, int weight) : base(name, height, weight)
        {
            this.diet = "omnivore";
        }
        public string walk()
        {
            return "Stomp stomp stomp";
        }
        public string run()
        {
            return "Knuckle dragging around quickly.";
        }

    }
    public class Gorilla : Hominidae
    {
        public Gorilla(string name, int height, int weight) : base(name, height, weight)
        {
            this.commonName = "Gorilla";
            this.scientificName = "Hominidae Gorilla";
        }
    }       
}