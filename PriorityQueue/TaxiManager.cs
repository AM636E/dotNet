using System;

namespace PriorityQueue
{
    class TaxiManager: Queue<Taxi>
    {
        public TaxiManager(Item<Taxi>[] array):
            base( array )
        { }

        public void GiveTax()
        {
            this.Pop();
        }
    }
}
