using System.Collections.Generic;

namespace Zoolandia.Habitats
{
    public class Grasslands : Habitat
    {
        private bool circle_of_life = true;
        public List<Employee> gameWardens = new List<Employee>();
        public Grasslands(string name) : base(name)
        {
        }
    
    }
}