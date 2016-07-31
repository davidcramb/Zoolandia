using System.Collections.Generic;
namespace Zoolandia.Habitats
{
    public class Cave : Habitat
    {
        public List<Employee> spelunkers = new List<Employee>();
        public Cave(string name) : base(name)
        {
        }
    }
}