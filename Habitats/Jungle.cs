using System.Collections.Generic;

namespace Zoolandia.Habitats
{
    public class Jungle : Habitat
    {
        private List<Employee> safariKeepers = new List<Employee>();
        public Jungle(string name) : base(name)
        {
        }
    }
}