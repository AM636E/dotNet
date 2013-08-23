using System;
using System.Collections.Generic;

namespace Car
{
    struct GPoint<T>
    {
        T x, y;

        public GPoint(T x, T y) { this.x = x; this.y = y; }
    
        public T X
        {
            get { return x; }
            set { x = value; }
        }
        public T Y
        {
            get { return y; }
            set { y = value; }
        }

        public override string ToString()
        {
            return
                "(" + x + "; " + y + ")";
        }
    }

    class Circle<T, R>
    {
        GPoint<T> center;
        R radius;

        public Circle(GPoint<T> center, R radius)
        {
            this.center = center;
            this.radius = radius;
        }

        public override string ToString()
        {
            return "Circle( " + center.ToString() + ',' + radius.ToString( ) + ");";
        }
    }

    struct A { }

    class E<T> where T : new() { }

    class Stack<T>
    {
        private T[] arr;
        private int size;

        public Stack()
        {
            arr = new T[1];
            size = 1;
        }

        public Stack(int size):
           this()
        {
            this.size = size;         
        }

        public Stack(T[] arr)
        {
            this.arr = arr;
            size = arr.Length;
        }

        public int Length
        {
            get{ return arr.Length; }
        }

        public bool IsEmpty() { return Length == 0; }
        public bool IsFull() { return Length < size; }

        public int Size { get { return size; } }

        public T Pop()
        {
            if (!IsEmpty())
            {
                T val = arr[arr.Length - 1];//get the last
                T[] copy = arr;

                arr = new T[arr.Length - 1];

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    arr[i] = copy[i];
                }

                return val;
            }

            throw new IndexOutOfRangeException("Stack is empty!");
        }

        public void Push(T value)
        {
            if (arr.Length == 1)
            {
                arr[0] = value;

                return;
            }
            if (Length < size)
            {
                T[] copy = arr;

                arr = new T[arr.Length + 1];

                for (var i = 0; i < copy.Length; i++)
                {
                    arr[i] = copy[i];
                }

                arr[arr.Length - 1] = value;
            }
            else
            {

                throw new IndexOutOfRangeException("Stack is full!");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           //System.Collections.ArrayList<int> alist = new 
            System.Collections.ArrayList alist = new System.Collections.ArrayList(2);

            alist.Add("Hey!");
            alist.Add("Hey!");
            alist.Add("Hey!");
            alist.Add("Hey!");
            alist.Add("Hey!");
            alist.Add("Hey!");
            alist.Add("Hey!");
            alist.Add("Hey!");
            alist.Add("Hey!");
            alist.Add("Hey!");
            alist.Add("Hey!");
            alist.Add("Hey!");

            Console.WriteLine(alist.Capacity);
            
            //try
            //{
            //    Game.Start();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //    Console.WriteLine(e.StackTrace);
            //}
        }
    }
}
