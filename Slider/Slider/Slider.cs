using System;

namespace Slider
{
    class Slider: Field
    {
        void a()
        {
            System.Text.RegularExpressions.Regex a = new System.Text.RegularExpressions.Regex(@"\s+");
            var b = Console.ReadLine();
            if (a.Match(b).Length == 0)
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
