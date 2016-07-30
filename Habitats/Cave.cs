using System.Collections.Generic;
namespace Zoolandia.Habitats
{
    public class Caves : Habitat
    {
        private List<Employee> spelunkers = new List<Employee>();
        public Caves(string name) : base(name)
        {
        }
    }
}