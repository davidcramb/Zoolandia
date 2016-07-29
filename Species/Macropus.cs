using System;
//kangaroo
namespace Zoolandia.Species
{
    public class Macropus : Animal, IHerbivore, IAmbulatory
    {
        public Macropus(string name, int height, int weight) : base(name, height, weight)
        {
            this.diet = "omnivore";
        }

        public string defend_against_predator()
        {
            return this.Name + " bounces backward on its tail and starts boxing Sylvester.";
        }

        public string graze()
        {
            return this.Name + " grazes on some grass.";
        }

        public virtual string hop(int number_of_hops)
        {
            return this.Name + " jumps around a bit.";
        }

        public string run()
        {
            return this.Name + " bounces away fast!";
        }

        public string walk()
        {
            return this.Name + " bounces around.";
        }
    }
    public class Giganteus : Macropus
    {
        public Giganteus(string name, int height, int weight) : base(name, height, weight)
        {
            this.commonName = "Eastern Gray Kangaroo";
            this.scientificName = "Marcopus Giganteus";
        }
        public override string hop(int number_of_hops)
        {
            return this.Name + " jumps around...a lot!";
        }
    }
}
   
