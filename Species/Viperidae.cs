using System;

namespace Zoolandia.Species
{
    public class Viperidae : Animal
    {
        public Viperidae(string name, int height, int weight) : base(name, height, weight)
        {
        }
    }
    public class Crotalus : Viperidae
    {
        public Crotalus(string name, int height, int weight) : base(name, height, weight)
        {
        }
    }       
}