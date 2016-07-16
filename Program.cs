using System;
using Zoolandia.Species;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AilurusFulgens redPanda = new AilurusFulgens("Steve");


            string response = redPanda.Eat(5);
            Console.WriteLine(redPanda.Name + " says " + response);
            AilurusFulgens Joe = new AilurusFulgens("Joe");
            Console.WriteLine(Joe.Welcome("Joe"));
            Console.WriteLine(Joe.Name + Joe.Eat() + Joe.Eat(1));
            // Console.WriteLine(Joe.Eat());
            // Console.WriteLine(Joe.Eat(3));
            Console.ReadLine(); //makes console wait for you instead of quitting outright
            {
                
            }
        }
    }
}
