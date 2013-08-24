using System;

namespace GStack
{
    class GStack<T>
    {
        private T[] array;
        private int capacity;
        private int count;

        public GStack()
        {
            array = new T[1];
            count = 0;
        }

        public GStack(int capacity):
            this()
        {
            this.capacity = capacity;
        }

        public int Capacity { get { return capacity; } }
        public int Count { get { return count; } }
        public bool Full
        {
            get { return count >= this.capacity; }
        }

        public bool Empty
        {
            get { return count == 0; }
        }      

        public T Pop()
        {
            if (!this.Empty)
            {
                T val = array[ --count ];

                T[] copy = array;

                array = new T[array.Length - 1];

                for (var i = 0; i < count; i++)
                {
                    array[i] = copy[i];
                }

                return val;
            }

            throw new Exception("Stack is empty!");
        }

        public void Push(T value)
        {
            if (count ++ == 0)
            {
               array[0] = value;

               return;
            }

            if (!this.Full)
            {
                T[] copy = array;

                array = new T[count];

                if (array.Length > 1)
                {
                    for (var i = 0; i < count -1; i++)
                    {
                        array[i] = copy[i];
                    }
                }

                array[count - 1] = value;

                return;
            }

            throw new Exception("Stack is Full!");
        }

        public override string ToString()
        {
            string tmp = "";

            for (var i = 0; i < array.Length; i++)
            {
                tmp += array[i].ToString() + '\n';
            }

            return tmp;
        }
    }
}
