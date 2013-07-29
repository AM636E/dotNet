using System;

namespace Car
{
    struct Point
    {
        int row, col;
        char ch;
        public ConsoleColor Color { get; set; }

        public Point(ConsoleColor color) : this() { Color = color; }

        public void Print()
        {
            Console.ForegroundColor = Color;
            Console.Write(ch);
            Console.ResetColor( );
        }

        public int Row
        {
            get { return row; }
            set { row = value; }
        }
        public int Col
        {
            get { return col; }
            set { col = value; }
        }

        public char Ch
        {
            get { return ch; }
            set { ch = value; }
        }
    }
}