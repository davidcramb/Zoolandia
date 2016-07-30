using System.Collections.Generic;
using Zoolandia.Species;

namespace Zoolandia.Habitats
{
    public abstract class Habitat
    {
        public Habitat(string name)
        {
            this.Name = name;
        }
        public string Name {get;set;}
        public List<Animal> inhabitants = new List<Animal>();
    }
}
