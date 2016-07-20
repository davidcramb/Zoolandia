using System;

namespace Zoolandia.Species
{
    public class Aptenodytes : Animal
    {
        public Aptenodytes(string name, int height, int weight) : base(name, height, weight)
        {
        }
    }
    public class Forsteri : Aptenodytes
    {
        public Forsteri(string name, int height, int weight) : base(name, height, weight)
        {
            this.commonName = "Emperor Penguin";
            this.scientificName = "Aptenodytes Forsteri";
        }
    }       
}