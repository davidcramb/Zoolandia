using System.Collections.Generic;

namespace Zoolandia.Habitats
{
    public class Savannah : Habitat
    {
        private List<Employee> wranglers = new List<Employee>();
        public Savannah(string name) : base(name)
        {
        }
    }
}