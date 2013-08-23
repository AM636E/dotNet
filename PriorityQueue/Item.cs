using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PriorityQueue
{
    struct Item<T>
    {
        T value;
        int priority;

        public Item(T value, int priority)
        {
            this.value = value;
            this.priority = priority;
        }

        public int Priority
        {
            get { return priority; }
            set { priority = value; }
        }

        public override System.String ToString()
        {
            return "|-" + value + "-" + "|-" + priority + "-| \n"; 
        }
    }
}
