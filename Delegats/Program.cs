using System;

namespace Delegats
{
    class Program
    {
        delegate void Mover();
        event Mover lMove;
        static void Main(string[] args)
        {
            //int n = 15;
            //int spaces = 0;
            //for (var i = n; i > 1; i -= 2)
            //{
            //    for (var j = 0; j < spaces; j++)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (var j = 0; j < i; j++)
            //    {
            //        if (j == 0 || j == i / 2 || j == i - 1)
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }
            //    }
            //    Console.WriteLine("");
            //    spaces++;
            //    //n -= 3;
            //}
            //n = 15;

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("*");
            //}
            //Console.Write("\n");
            //spaces = n / 2;
            //for (var i = 0; i < n - 1; i += 2)
            //{
            //    for (var j = 0; j < spaces; j++)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (var j = 0; j < i + 1; j++)
            //    {
            //        if (j == 0 || j == i / 2 || j == i)
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }
            //    }
            //    Console.WriteLine("");
            //    spaces--;
            //    //n -= 3;
            //}
            while (true)
            {
                   Console.WriteLine( Console.ReadKey().Key );
            
            }
        }
    }
}
