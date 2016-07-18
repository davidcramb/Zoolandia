using System;

namespace Zoolandia.Species
{
    public class Animal
    {
        public Animal (string name, int height, int weight) 
        {
            this.Name = name; //constructors used when instantiating classes so they can be used later
            this.Height = height;
            this.Weight = weight;
        }
        public Animal (string name)
        {
            this.Name = name;
        }
        
        
        public string Name {get; set;} //allows us to set and return Name
        public int Weight {get; set;}
        public int Height {get; set;}

        public string Sleep(int hoursSlept)
        {
            return "I slept for " + hoursSlept + " hours";
        }
        
        public virtual string MatingDance()
        {
            return "Everyone laughed at me...";
        }
        
        // add virtual so that method can be overwritten
        public virtual string Eat(int numberOfFoods) 
        { 
            return "YUM";
        }
        public virtual string Sound()
        {
            return "The cow says moo.";
        }
    }
}