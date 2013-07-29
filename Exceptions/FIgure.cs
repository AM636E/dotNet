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

        public double GetLength(Point second)
        {
            return (
                    Math.Sqrt((second.x - this.x) * (second.x - this.x) +
                              (second.y - this.y) * (second.y - this.y)
                ));
        }

    }

    abstract class Figure
    {
        public virtual double Square { get { return 0; } }
        public virtual double Perimetr { get { return 0; } }
    }

    class Triangle : Figure
    {
        int a, b, c;


        public int A
        {
            get { return a; }
            set { a = value; }
        }

        public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double Square
        {
            get
            {
                double p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
        }

        public override double Perimetr
        {
            get { return a + b + c; }
        }
    }

    class FourAngle : Figure
    {
        protected int a, b, c, d;

        public FourAngle(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public override double Perimetr
        {
            get
            {
                return a + b + c + d;
            }
        }
    }

    class Paralellogram : FourAngle
    {
        public Paralellogram(int a, int b ) :
            base(a, b, a, b) { }

        public override double Square
        {
            get
            {
                return a * b;
            }
        }
    }

    class Square : Paralellogram
    {
        Square(int a) :
            base(a, a) { }
        
    }

    class Trapess : FourAngle
    {
        public Trapess(int left, int right, int up, int down ) :
            base(left, right, up, down) { }

        public override double Square
        {
            get
            {
                var middleLine = (c + d) / 2;
                return 0;
            }
        }
    }

    class Circle : Figure
    {
        private double radius;

        public Circle( double radius )
        {
            this.radius = radius;
        }

        public override double Perimetr
        {
            get
            {
                return 2 * Math.PI * radius;
            }
        }

        public override double Square
        {
            get
            {
                return Math.PI * radius * radius;
            }
        }
    }
}
