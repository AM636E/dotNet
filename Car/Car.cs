using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Car
{
    class Car:Sprite, IMovable
    {
        const char CAR_LETTER = 'O';

        
        public Car() :
            base(1, 1, CAR_LETTER)
        {

        }

        public Car(int startRow, int startCol) :
            this()
        {
            for (var i = 0; i < Rows; i++)
            {
                for (var j = 0; j < Cols; j++)
                {
                    matrix[i, j].Row = i + startRow;
                    matrix[i, j].Col = j + startCol;
                }
            }
        }

        public Car(Car copy):
            base(copy )
        {
        }

        public void MoveRight()
        {
            // this.matrix = new Car(matrix[0, 0].Row, matrix[0, 0].Col + 1).matrix;
            ActWithMatrix(delegate(Point p)
            {
                p.Col++;

                return p;
            });
        }

        public void MoveLeft()
        {
            //this.matrix = new Car(matrix[0, 0].Row, matrix[0, 0].Col - 1).matrix;
            ActWithMatrix(delegate(Point p)
            {
                p.Col--;

                return p;
            });
        }
    }
}
