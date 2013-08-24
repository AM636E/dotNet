using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GStack
{
    class Program
    {
        static void Main(string[] args)
        {
            GStack<int> s = new GStack<int>(3);
            
            try
            {
                s.Push(20);
                s.Push(2);
                Console.WriteLine(s.Pop());
                Console.WriteLine(s.Pop());
                Console.WriteLine(s.Pop());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
