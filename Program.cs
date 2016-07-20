using System;
using Zoolandia.Species;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AilurusFulgens redPanda = new AilurusFulgens("Steve", 20, 200);
            AilurusFulgens Joe = new AilurusFulgens("Joe", 19, 185);
            SuricataSuricatta Bob = new SuricataSuricatta("Bob", 15, 100);
            IguanidaeIguana Quincy = new IguanidaeIguana("Quincy", 8, 35);
            StruthioCamelus Dee = new StruthioCamelus("Dee", 50, 300);
            OctopusVulgaris Ultros = new OctopusVulgaris("Ultros", 20, 220);
            OctopusVulgaris Inky = new OctopusVulgaris("Inky");
            Giganteus Hoppy = new Giganteus ("Hoppy", 50, 225);
            Tigris Hobbes = new Tigris("Hobbes",60, 300);

            Console.WriteLine("hello" + Hoppy.commonName);
            Console.WriteLine(redPanda.Name);
            Console.WriteLine(Joe.Name);
            Console.WriteLine(Bob.Name);
            Console.WriteLine(Quincy.Name);
            Console.WriteLine(Ultros.Name);


            string response = redPanda.Eat(5);
            Console.WriteLine(redPanda.Name + " says " + response);
            Console.WriteLine(Joe.Welcome("Joe"));
            Console.WriteLine(Joe.Name + Joe.Eat() + Joe.Eat(1));
            Console.WriteLine(Bob.Eat(5) + Bob.MatingDance() + " " +  Bob.Height);
            Console.WriteLine(Bob.Sound("dangerous", 10));

            Console.WriteLine(Quincy.MatingDance());
            Console.WriteLine(Dee.Hide(7));
            Console.WriteLine(Ultros.pushHeavyWeight(5));
            Console.WriteLine(Ultros.MatingDance());
            Console.WriteLine(Hobbes.hunt_prey(5));

            Console.ReadLine(); //makes console wait for you instead of quitting outright
            {
                
            }
        }
    }
}
