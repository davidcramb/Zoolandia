using System;

namespace Zoolandia.Species
{
    public class Lissemys : Animal
    {
        public Lissemys(string name, int height, int weight) : base(name, height, weight)
        {
            this.diet = "omnivore";
        }
    }
    public class Punctata : Lissemys
    {
        public Punctata(string name, int height, int weight) : base(name, height, weight)
        {
            this.commonName = "Indian Flapshell Turtle";
            this.scientificName = "Lissemys Punctata";
        }
    }       
}