using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matrix
{
    class Program
    {      

        static void Fun( ref int x )
        {
            //x = 10;
             x ++;
             Console.WriteLine(x);
        }
        static void Main(string[] args)
        {
            Figure a = new Figure();
            Figure b = new Figure();
            Figure c = new Figure();
            Figure d = new Figure();
            Figure e = new Figure();
            Figure f = new Figure();
            
            Console.WriteLine(a);
            Console.WriteLine("Count of figures: {0}", Figure.count - 1);
			
			Console.ReadKey( );
		}
    }
}
