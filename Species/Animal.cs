using System;

namespace Zoolandia.Species
{
    public class Animal
    {
        public Animal (string name) 
        {
            this.Name = name; //constructors used when instantiating classes so they can be used later
        }
        public string Name {get; set;} //allows us to set and return Name
        
        // add virtual so that method can be overwritten
        public virtual string Eat(int numberOfFoods) 
        { 
            return "YUM";
        }
    }
}