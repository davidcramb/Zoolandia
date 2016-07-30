using System.Collections.Generic;
namespace Zoolandia.Habitats
{
    public class Aquarium : Habitat
    {
        private bool _saltwater = false;
        private List<Employee> scubaCrew = new List<Employee>();
        
        public Aquarium(string name) : base (name)
        {

        }

    }
}