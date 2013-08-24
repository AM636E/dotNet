using System;

namespace PriorityQueue
{
    class Taxi: Item<string>
    {
        private string name;

        public Taxi(string name, int priority):
            base( name, priority )
        { }

        public string Name { get { return name; } }
    }
}
