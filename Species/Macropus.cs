using System;
//kangaroo
namespace Zoolandia.Species
{
    public class Macropus : Animal
    {
        public Macropus(string name, int height, int weight) : base(name, height, weight)
        {
        }
        public virtual string hop(int number_of_hops)
        {
            return this.Name + " jumps around a bit.";
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
   
