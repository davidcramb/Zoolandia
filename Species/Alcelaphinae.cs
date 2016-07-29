using System;

namespace Zoolandia.Species
{
    public class Alcelaphinae : Animal, IHerbivore, IAmbulatory
    {
        public Alcelaphinae(string name, int height, int weight) : base(name, height, weight)
        {
            this.diet = "herbivore";
        }
        public virtual string gallop (int numberOfAnimal)
        {
            return "A herd of " + numberOfAnimal + " antelopes gallops around.";
        }
        public string graze()
        {
            return this.Name + " meanders and chews on grass and dirt.";
        }
        public string defend_against_predator()
        {
            return "...hello?";
        }
        public string defend_against_predator(int numOfPredators)
        {
            if (numOfPredators == 1)
            {
            return this.Name + " kicks at the hungry carnivore with its hind legs!";
            }
            else if (numOfPredators > 1){
                return run();
            }
            else if (numOfPredators < 1)
            {
                return this.Name + " looks around cautiously.";
            }
            return  "barf";
        }
        public string defend_against_predator(int numOfAntelopes, string typeOfCarnivore)
        {
            return this.Name + " brought" + numOfAntelopes + " antelope friends and gang up on the " + typeOfCarnivore + ".";
        }
        public string walk ()
        {
            return this.Name + " goes on a nice walk.";
        }
        public string run () 
        {
            return this.Name + " runs away quickly!";
        }
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