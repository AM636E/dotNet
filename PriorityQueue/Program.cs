using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PriorityQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> e = new Queue<int>();

            e.Push(new Item<int>(10, 2));
            e.Push(new Item<int>(10, 4));
            e.Push(new Item<int>(10, 2));
            e.Push(new Item<int>(10, 4));
            e.Push(new Item<int>(10, 2));
            e.Push(new Item<int>(10, 244));
            e.Push(new Item<int>(10, 2));
            e.Push(new Item<int>(10, 2));

            Console.WriteLine(e);
        }
    }
}
