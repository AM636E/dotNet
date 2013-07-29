using System;

namespace Slider
{
    class GameField
    {        
        public GameField()
        {
        }
        
        public class Point
        {
            int x, y;
        }

        public class Matrix
        {
            char[,] matrix;

            public Matrix( int rows, int cols )
            {
                matrix = new char[ rows, cols ];
            }

            public void Draw()
            {
                for (var i = 0; i < matrix.GetLength(0); i++)
                {
                    for (var j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write(matrix[i, j]);
                    }
                    Console.Write('\n');
                }
            }
        }
    }
}
