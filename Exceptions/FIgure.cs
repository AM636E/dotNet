using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exceptions
{
    class Point
    {
        double x, y;
        public double X
      {
          set
          {
              x = value;
          }
          get
          {
              return x;
          }
      }
        public double Y
      {
          set
          {
              y = value;
          }
          get
          { return y; }
      }

        public double GetLength( Point second)
        {
            return (
                    Math.Sqrt((second.x - this.x) * (second.x - this.x) +
                              (second.y - this.y) * (second.y - this.y)
                ));
        }
        
    }

    abstract class Figure
    {
        public virtual double Square;
        public virtual double Perimetr; 
    }

    class Triangle : Figure
    {
       
       public Triangle( Point a, Point b, Point c )
        {   
        }
    }
}
