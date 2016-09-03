using System.Collections.Generic;

namespace Zoolandia.Habitats
{
    public class Savannah : Habitat
    {
        public List<Employee> safariWranglers = new List<Employee>();
        public Savannah(string name) : base(name)
        {
        }
    }
}