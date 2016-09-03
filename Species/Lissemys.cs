using System;

namespace Zoolandia.Species
{
    public class Lissemys : Animal, IReptile, IHerbivore, IPredator, IAmbulatory, IAquatic
    {
        public Lissemys(string name, int height, int weight) : base(name, height, weight)
        {
            this.diet = "omnivore";
        }

        public string bite()
        {
            return "Chomp.";
        }

        public string claw()
        {
            return null;
        }

        public string defend_against_predator()
        {
            return this.Name + " retreats into its shell!";
        }

        public string dive()
        {
            return "Dive dive dive hit the burners pilot!";
        }

        public string get_warm()
        {
            return null;
        }

        public string graze()
        {
            return "It eats algae or whatever.";
        }

        public string hunt()
        {
            return this.Name + " plods along looking for something slower than it is to eat.";
        }

        public string lay_eggs()
        {
            return "Don't look!";
        }

        public string run()
        {
            return this.Name + " stands up on its hind legs and starts jogging around! Can you believe it?!";
        }

        public string stalk()
        {
            return this.Name + " naturally stalks other creatures because that is its only means of conveyance.";
        }

        public string surface()
        {
            return this.Name + " breaks the surface of the water for air.";
        }

        public string swim()
        {
            return this.Name + " swims around.";
        }

        public string walk()
        {
            return this.Name + " walks around, very, very, very slowly.";
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