using System;
using System.Collections.Generic;
using Zoolandia.Species;
using Zoolandia.Habitats;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Alcelaphinae Smith = new Alcelaphinae("Smith", 50, 180);
            Aptenodytes Waddles = new Aptenodytes("Waddles", 30, 40);
            Bicornis Ginger = new Bicornis("Ginger", 20, 30);
            Anna Dean = new Anna("Dean", 2, 5);
            Adamanteus Rattles = new Adamanteus("Rattles", 1, 10);
            Rotundus Dracula = new Rotundus("Dracula", 7, 15);
            Rotundus Batman = new Rotundus("Batman", 7, 15);
            Rotundus Robin = new Rotundus("Robin", 7, 15);
            Rotundus Nosferatu = new Rotundus("Nosferatu", 7, 15);
            Camelopardalis Spotty = new Camelopardalis("Spotty", 200, 200);
            Helix Sonic = new Helix("Sonic", 1, 1);
            Helix Lightning = new Helix("Lightning", 1, 1);
            Punctata Razor = new Punctata("Razor", 6, 12);
            Camelus Dee = new Camelus("Dee", 50, 300);
            Fulgens Steve = new Fulgens("Steve", 20, 200);
            Fulgens Joe = new Fulgens("Joe", 19, 185);
            Africana Stampy = new Africana("Stampy", 180, 500);
            Giganteus Hoppy = new Giganteus ("Hoppy", 50, 225);
            Hominidae Bullseye = new Hominidae("Bullseye", 60, 300);
            Iguana Quincy = new Iguana("Quincy", 8, 35);
            Octopus Inky = new Octopus("Inky");
            Octopus Ultros = new Octopus("Ultros", 20, 220);
            Scandiacus Fluffy = new Scandiacus("Fluffy", 30, 30);
            Suricatta Bill = new Suricatta("Bill", 15, 100);
            Suricatta Ted = new Suricatta("Ted", 15, 100);
            Tigris Hobbes = new Tigris("Hobbes",60, 300);
            Pacos FalseLlama = new Pacos("FalseLlama", 75, 125);
            
            // Instantiate new Habitats
            Aquarium SeaWorld = new Aquarium("SeaWorld");
            Jungle JungleWorld = new Jungle("JungleWorld");
            Cave BatCave = new Cave("BatCave");
            Savannah SavannahWorld = new Savannah("SavannahWorld");
            Grasslands GrassWorld = new Grasslands("GrassWorld");
            List<Animal> SeaAnimals = new List<Animal> {Ultros, Inky, Waddles};
            foreach (var animal in SeaAnimals)
            {
                SeaWorld.inhabitants.Add(animal);
            }
            List<Animal> JungleAnimals = new List<Animal> {Hobbes, Quincy, Dean, Ginger, Bullseye};
            foreach (var animal in JungleAnimals)
            {
                JungleWorld.inhabitants.Add(animal);
            }
            List<Animal> CaveAnimals = new List<Animal> {Dracula, Batman, Robin, Nosferatu};
            foreach (var animal in CaveAnimals)
            {
                BatCave.inhabitants.Add(animal);
            }
            List<Animal> SavannahAnimals = new List<Animal> {Bill, Ted, Smith, Dee, Hoppy, Stampy, Rattles};
            foreach (var animal in SavannahAnimals)
            {
                SavannahWorld.inhabitants.Add(animal);
            }
            List<Animal> GrasslandAnimals = new List<Animal> {Fluffy, FalseLlama, Razor};
            foreach (var animal in GrasslandAnimals)
            {
                GrassWorld.inhabitants.Add(animal);
            }
            Employee Kate = new Employee("Kate");
            Employee Jurnell = new Employee("Jurnell");
            Employee Zoe = new Employee("Zoe");
            Employee Greg = new Employee("Greg");
            Employee Callan = new Employee("Callan");
            Employee John = new Employee("John");
            Employee Barry = new Employee("Barry");
            Employee Other_Barry = new Employee("Other Barry");
            Employee Blaise = new Employee("Blaise");
            SeaWorld.scubaCrew.Add(Kate);
            SeaWorld.scubaCrew.Add(Jurnell);
            JungleWorld.gameWardens.Add(Greg);
            JungleWorld.gameWardens.Add(Zoe);
            SavannahWorld.safariWranglers.Add(Callan);
            SavannahWorld.safariWranglers.Add(John);
            BatCave.spelunkers.Add(Barry);
            BatCave.spelunkers.Add(Other_Barry);
            GrassWorld.gameWardens.Add(Blaise);
            
            Console.WriteLine("Welcome to Savannah World, where you can see: ");
            foreach (var animal in SavannahWorld.inhabitants)
            {
                Console.Write(animal.Name + " the " + animal.commonName + ", ");
            }
            Console.Write(".");
            Console.WriteLine("We hope you enjoy yourself!");


            

            Console.ReadLine(); //makes console wait for you instead of quitting outright
            {
                
            }
        }
    }
}