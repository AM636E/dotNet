using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Car
{
    class Holl : Sprite, IStatic
    {
        const char HOLL_LETTER = '-';

        //events
        public event EventHandler HollMoveEvent;
        public event EventHandler HollIsDownEvent;
        private int p;

        public Holl() :
            base(1, 1, HOLL_LETTER)
        {

        }

        public Holl(int startRow, int startCol) :
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

        public Holl(int p)
        {
            // TODO: Complete member initialization
            this.p = p;
        }

        public void MoveDown()
        {
            //  this.matrix = new Holl(matrix[0, 0].Row + 1, matrix[0, 0].Col).matrix;

            ActWithMatrix(delegate(Point p)
            {
                p.Row++;

                return p;
            });
        }

        public EventHandler RoadMoveHandler()
        {
            return delegate(object sender, EventArgs args)
            {
                HollMoveEvent(this, EventArgs.Empty);
            };
        }
    }
}
