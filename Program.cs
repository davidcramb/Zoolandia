using System;
using Zoolandia.Species;
using Zoolandia.Habitats;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Fulgens redPanda = new Fulgens("Steve", 20, 200);
            Fulgens Joe = new Fulgens("Joe", 19, 185);
            Suricatta Bob = new Suricatta("Bob", 15, 100);
            Iguana Quincy = new Iguana("Quincy", 8, 35);
            Camelus Dee = new Camelus("Dee", 50, 300);
            Octopus Ultros = new Octopus("Ultros", 20, 220);
            Octopus Inky = new Octopus("Inky");
            Giganteus Hoppy = new Giganteus ("Hoppy", 50, 225);
            Tigris Hobbes = new Tigris("Hobbes",60, 300);
            Scandiacus Fluffy = new Scandiacus("Fluffy", 30, 30);
            Camelopardalis Spotty = new Camelopardalis("Spotty", 200, 200);
            // Console.WriteLine("hello" + Hoppy.commonName);
            // Console.WriteLine(redPanda.Name);
            // Console.WriteLine(Joe.Name);
            // Console.WriteLine(Bob.Name);
            // Console.WriteLine(Quincy.Name);
            // Console.WriteLine(Ultros.Name);


            string response = redPanda.Eat(5);
            // Console.WriteLine(redPanda.Name + " says " + response);
            // Console.WriteLine(Joe.Name + Joe.Eat(3) + Joe.Eat(1));
            // Console.WriteLine(Bob.Eat(5) + Bob.MatingDance() + " " +  Bob.Height);
            // Console.WriteLine(Bob.Sound("dangerous", 10));

            // Console.WriteLine(Quincy.MatingDance());
            // Console.WriteLine(Dee.Hide(7));
            // Console.WriteLine(Ultros.pushHeavyWeight(5));
            // Console.WriteLine(Ultros.MatingDance());
            // Console.WriteLine(Hobbes.hunt_prey(5));
            Console.WriteLine(Fluffy.hunt() + Fluffy.hunt(Ultros.Name));
            Console.WriteLine(Spotty.defend_against_predator("not a lion")); //returns null
            Console.WriteLine(Spotty.defend_against_predator("lion"));

            Console.ReadLine(); //makes console wait for you instead of quitting outright
            {
                
            }
        }
    }
}
