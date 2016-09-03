

using System;

namespace Zoolandia.Species 
{
    public class Iguanidae : Animal, IAmbulatory, IHerbivore, IPredator
    {
        public Iguanidae(string name, int height, int weight) : base(name, height, weight) 
        {
            this.diet = "omnivore";
        } 

        public Iguanidae(string name) : base(name)
        {
        }  
        public override string Eat(int numOfCrickets) 
        {
            return this.Name + " ate " + numOfCrickets + " crickets and spinach leaves.";
        }
        public override string Sound()
        {
            string animalSound = base.Sound();
            return "Hiss?";
        }
        public override string MatingDance()
        {
            return this.Name + " side steps around and raises its tail.";
        }

        public string walk()
        {
            return "Skitter skitter skitter.";
        }

        public string run()
        {
            return "Skitter quickly.";
        }

        public string graze()
        {
            return this.Name + " munches on a leaf.";
        }

        public string defend_against_predator()
        {
            return this.Name + " detaches its tail and escapes!";
        }

        public string hunt(string prey)
        {
            return this.Name + " lashes out at a " + prey + "!";
        }
        public string hunt()
        {
            return null;
        }

        public string bite()
        {
            return this.Name + " chomps down hard!";
        }

        public string claw()
        {
            return this.Name + " claws rather ineffectively.";
        }

        public string stalk()
        {
            return this.Name + " creeps up on its target.";
        }
    }
    public class Iguana : Iguanidae
    {
        public Iguana(string name, int height, int weight) : base (name, height, weight)
        {
            this.commonName = "Green Iguana";
            this.scientificName = "Iguanidae Iguana";
            this.isCute = true;
        }
    }
}