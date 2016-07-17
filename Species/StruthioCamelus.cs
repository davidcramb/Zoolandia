using System;

namespace Zoolandia.Species
{
    public class StruthioCamelus : Animal
    {
        public StruthioCamelus(string name, int height, int weight) : base (name, height, weight) 
        {
        }
            private string StickHeadInSand(int days)
            {
                return "Let me know when this all blows over...should be about " + days + " days.";
            }
            public string Hide(int days)
            {
                return StickHeadInSand(days);
            }
    }
}