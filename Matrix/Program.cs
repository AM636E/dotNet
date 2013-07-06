using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            //Matrix a = new Matrix(new int[2, 2] { { 2, 2 }, { 3, 4 } });
            //Matrix b = new Matrix(new int[2, 2] { { 1, 2 }, { 3, 5 } });
            //Matrix c = new Matrix(new int[3, 2] { { 2, 3 }, { 4, 5 }, { 3, 6 } });

            //Console.WriteLine("a");
            //Console.WriteLine(a);
           
            //Console.WriteLine("b");
            //Console.WriteLine(b);
           
            //Console.WriteLine("c");
            //Console.WriteLine(c);


            //Matrix d = a.Mul(b);

            //Console.WriteLine("d");
            //Console.WriteLine(d);

            //Console.WriteLine("c");
            //Console.WriteLine(c.Mul( 3 ));

            //a.Add(c);
            for (int i = 1; i < 100; i++)
            {
                Console.Write(i * i);
            }
        }
    }
}
