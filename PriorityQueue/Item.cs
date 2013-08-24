using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PriorityQueue
{
    class Item<T>
    {
        protected T value;
        protected int priority;

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

        public T GetValue { get { return value; } }

        public override System.String ToString()
        {
            return "|-" + value + "-" + "|-" + priority + "-| \n"; 
        }
    }
}
