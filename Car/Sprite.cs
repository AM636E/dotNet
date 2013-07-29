using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Car
{
    abstract class Sprite : Matrix
    {
        public Sprite() :
            base() { }

        public Sprite(int a, int b, char ch) :
            base(a, b, ch) { }

        public Sprite(Sprite copy):
            base(copy)
        {
        }

        public new void EraseFrom(Matrix r)
        {
            var a = matrix[0, 0];

            if (a.Row > 0 && a.Col > 0 && a.Row < r.Rows && a.Col < r.Cols)
            {
                r.GetMatrix()[a.Row, a.Col].Ch = Road.Road_Letter;
            }
        }
    }
}
