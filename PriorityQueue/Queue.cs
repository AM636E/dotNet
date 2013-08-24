using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PriorityQueue
{
    class Queue<T>
    {
        protected Item<T>[] array;
        private Taxi[] array_2;

        public Queue() { array = new Item<T>[1]; }
        
        public Queue(Item<T>[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                this.Push(array[i]);
            }
        }

        protected int GetPos(Item<T> value)
        {
            if (array.Length == 1)
            {
                return 0;
            }
         
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (value.Priority >= array[i].Priority)
                {
                    return i;
                }
            }

            return -1;
        }

        public void Push(Item<T> value)
        {
            int priority = value.Priority;
            int pos = GetPos( value );

            Item<T>[] copy = array;
            array = new Item<T>[array.Length + 1];

            for (var i = 0; i < array.Length; i++)
            {
                if (i < pos)
                {
                    array[i] = copy[i];
                }
                else if (i > pos)
                {
                    array[i] = copy[i - 1];
                }
            }

            if (pos >= 0 && pos < array.Length)
            {
                array[pos] = value;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public Item<T> Pop()
        {
            var first = array[0];

            for (var i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }

            array[array.Length - 1] = first;
            this.Push(first);

            return first;
        }

        public override string ToString()
        {
            var output = "";

            for (var i = 0; i < array.Length; i++)
            {
                output += array[i].ToString();
            }

            return output;
        }
    }
}
