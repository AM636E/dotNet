using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Car
{
    class Holl : Sprite, IStatic
    {
        const char HOLL_LETTER = 'h';

        //events
        public event EventHandler HollMoveEvent;
        public event EventHandler HollIsDownEvent;

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

        public void MoveDown()
        {
            this.matrix = new Holl(matrix[0, 0].Row + 1, matrix[0, 0].Col).matrix;

        }

        public EventHandler RoadMoveHandler()
        {
            return delegate( object sender, EventArgs args)
            {
                HollMoveEvent(this, EventArgs.Empty);
            };
        }
    }
}
