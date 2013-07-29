using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Slider
{
    class Field
    {
        char[,] matrix;
        static int rows, cols;

        class Point
        {
            private char ch;

            public char Ch
            {
                get
                {
                    return ch;
                }
                set
                {
                    ch = value;
                }
            }

            private int x, y;

            public int X
            {
                get
                {
                    return x;
                }
                set
                {
                    x = value;
                }
            }

            public int Y
            {
                get { return y; }
                set { y = value; }
            }

            //true - figure moving
            decimal a = 10.0000000000012596m;
        }

        

        public Field(int rows, int cols)
        {
            
        }
    }
}
