using System.Collections.Generic;

namespace Zoolandia.Habitats
{
    public class Jungle : Habitat
    {
        public List<Employee> gameWardens = new List<Employee>();
        public Jungle(string name) : base(name)
        {
        }
    }
}