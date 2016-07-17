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


            string response = redPanda.Eat(5);
            Console.WriteLine(redPanda.Name + " says " + response);
            AilurusFulgens Joe = new AilurusFulgens("Joe", 19, 185);
            Console.WriteLine(Joe.Welcome("Joe"));
            Console.WriteLine(Joe.Name + Joe.Eat() + Joe.Eat(1));
            SuricataSuricatta Bob = new SuricataSuricatta("Bob", 15, 100);
            Console.WriteLine(Bob.Eat(5) + Bob.MatingDance() + " " +  Bob.Height);

            IguanidaeIguana Quincy = new IguanidaeIguana("Quincy", 8, 35);
            
            // Console.WriteLine(Quincy.Name);
            // Console.WriteLine(Quincy.Height);
            // Console.WriteLine(Quincy.Weight);
            StruthioCamelus Dee = new StruthioCamelus("Dee", 50, 300);
            Console.WriteLine(Dee.Hide(7));
            OctopusVulgaris Ultros = new OctopusVulgaris("Ultros", 20, 220);
            Console.WriteLine(Ultros.pushHeavyWeight(5));
            Console.ReadLine(); //makes console wait for you instead of quitting outright
            {
                
            }
        }
    }
}
