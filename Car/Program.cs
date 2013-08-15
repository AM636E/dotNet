using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Game.Start();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
