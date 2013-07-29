using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Slider
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Text.RegularExpressions.Regex a = new System.Text.RegularExpressions.Regex(@"\s+");
            
            if (a.Match(Console.ReadLine()).Length == 0)
            {
                Console.Title = "No Spaces";
            }
            else
            {
                Console.Title = "Yea spaces";
            }
        }
    }
}
