using System;

namespace Matrix
{
    class Fraction
    {
        double whole;
        double fractional;
        double number;

        Fraction()
        {
            whole = fractional = number = 0;             
        }

        Fraction(double number)
        {
            this.number = number;
            whole = Convert.ToInt32(number);
            fractional = number - whole;
        }

        Fraction(Fraction f)
        {
            this.whole = f.whole;
            this.fractional = f.fractional;
            this.number = f.number;
        }

        public Fraction Add(Fraction f)
        {
            return new Fraction(this.number + f.number);           
        }

        public Fraction Sub(Fraction f)
        {
            return new Fraction(this.number - f.number);
        }

        public Fraction Mul(double num)
        {
            return new Fraction(this.number * num);
        }

        public Fraction Add(double num)
        {
            return new Fraction(this.number + num);
        }

        public Fraction Sub(double num)
        {
            return new Fraction(this.number - num);
        }

        /*public Fraction Mul(double num)
        {
            return new Fraction(this.number * num);
        }
        */
        public Fraction Div(Fraction f)
        {
            if (f.number != 0)
            {
                return new Fraction(this.number / f.number);
            }

            return new Fraction(2);
        }
        public Fraction Div(double num)
        {
            if (num != 0)
            {
                return new Fraction(this.number / num);
            }

            return new Fraction(2);
        }

        public override string ToString()
        {
            return this.number.ToString();
        }
    }
}
