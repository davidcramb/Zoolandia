using System;

namespace Zoolandia.Species
{
    public class Desmodus : Animal, IFlying, IPredator
    {
        public Desmodus(string name, int height, int weight) : base(name, height, weight)
        {
            this.diet = "carnivore";
        }
        public string fly()
        {
            return "I am the terror that flaps in the night.";
        }
        public string land()
        {
            return this.Name + " lands upside down in a cave and sleeps.";
        }
        public string hunt()
        {
            return fly() + " " + sonar();
        }
        public string hunt(string prey)
        {
            return fly() + " " + sonar() + " Found a " + prey + " to steal blood from.";
        }
        public string claw()
        {
            return "Tries to scratch the skin.";
        }
        public string bite()
        {
            return "I vant to suck your blood. Bleh! Bleh!";
        }
        public string stalk()
        {
            return null;
        }
        public string sonar()
        {
            return "skree! skree! skree!";
        }
    }
    public class Rotundus : Desmodus
    {
        public Rotundus(string name, int height, int weight) : base(name, height, weight)
        {
            this.commonName = "Vampire Bat";
            this.scientificName = "Desmodus Rotundus";
        }
        public string drainBlood()
        {
            return "Aieeeee!";
        }
    }       
}