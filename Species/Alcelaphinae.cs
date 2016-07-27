using System;

namespace Zoolandia.Species
{
    public class Alcelaphinae : Animal
    {
        public Alcelaphinae(string name, int height, int weight) : base(name, height, weight)
        {
            this.diet = "herbivore";
        }
        public virtual string gallop (int numberOfAnimal)
        {
            return "A herd of " + numberOfAnimal + " antelopes gallops around.";
        }
        public override 
    }
    public class Connochaetes : Alcelaphinae
    {
        public Connochaetes(string name, int height, int weight) : base(name, height, weight)
        {
        }
        public string gallop ()
        {
            return "The antelope gallops on its own";
        }
        public override string gallop (int numberOfAnimal)
        {
            return "The antelope gallops on its own...";
        }
        public string gallop (int numberOfAnimal, string newAnimal)
        {
            return numberOfAnimal + " antelopes gallop alongside a " + newAnimal + ".";
        }
    }       
}