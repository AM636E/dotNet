using System;

namespace Matrix
{
    class Algebra
    {
        static double SolveLinear(double a, double b, double c)
        {
            return ( c - b ) / a; 
        }
        static double[] SolveSquare(double a, double b, double c)
        {
            double d = b * b - 4 * a * c;
            double[] res = new double[2];
            if (d < 0)
            {
                Console.WriteLine("No solution");
                
                return res;
            }

            if (d == 0)
            {
                Console.WriteLine( "One solution" );
                 res[0] = -(b / 2 * a);
                 return res;
            }

            res[0] = (-b - Math.Sqrt(d)) / 2 * a;
            res[1] = (-b + Math.Sqrt(d)) / 2 * a;

            return res;
        }

        static int NSD(int a, int b)
        {
            if (a == 0)
            {
                return b;
            }

            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;            
            }

            return a;
        }

        static int NSD(int a, int b, int c)
        {
            return NSD(a, NSD(b, c));
        }

        static int NSD(int a, int b, int c, int d)
        {
            return NSD(NSD(a, b, c), d);
        }

        static int NSD(int a, int b, int c, int d, int e)
        {
            return NSD(NSD(a, b, c, d), e);
        }

        static bool IsInBubble(int x, int y)
        {
            return (
                    (2 * x * x + 3 * y * y >= 25)
                    &&
                    (x * x + (y + 2) * (y + 2) <= 49)
                );
        }

        static int GetK(int k)
        {
            return 0;
        }

    }
}
