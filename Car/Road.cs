using System;

namespace Car
{
    class Road : Matrix, IMoveCanvas
    {
        private const char ROAD_LETTER = ' ';
        private const char ROAD_SEPARATOR = '|';

        //events
        public event EventHandler RoadMoved;
        public event EventHandler NeedNewHollEvent;

        public static char Road_Letter
        {
            get { return ROAD_LETTER; }
        }

        public static char Road_Separator
        {
            get { return ROAD_SEPARATOR; }
        }

        public Road(int rows, int cols) :
            base(rows, cols, ROAD_LETTER)
        {
            var c = cols / 2;

            for (var i = 0; i < rows; i += 2)
            {
                matrix[i, c].Ch = ROAD_SEPARATOR;
            }
        }

        public void Move()
        {
            var c = Cols / 2;

            for (var i = 0; i < Rows; i++)
            {
                if (matrix[i, c].Ch == ROAD_SEPARATOR)
                {
                    matrix[i, c].Ch = Road_Letter;
                }
                else
                {
                    matrix[i, c].Ch = ROAD_SEPARATOR;
                    matrix[i, c].Color = ConsoleColor.Green;
                }
            }

            RoadMoved(this, EventArgs.Empty);
        }

        public MoveStage IsCanMoveLeft(Matrix m)
        {
            Point tmp;//see is can move down

            for (var i = 0; i < m.Rows; i++)
            {
                tmp = m[i, 0];
                if (tmp.Col - 1 < 0)
                {
                    return MoveStage.OUT_OF_RANGE;
                }
                if (this[tmp.Row, tmp.Col - 1].Ch != ROAD_LETTER)
                {
                    return MoveStage.COLLISION;
                }
            }

            return MoveStage.OK;
        }

        public MoveStage IsCanMoveRight(Matrix m)
        {
            Point tmp;//see is can move left

            for (var i = 0; i < m.Rows; i++)
            {
                tmp = m[i, 0];
                if (tmp.Col + 1 >= this.Cols)
                {
                    return MoveStage.OUT_OF_RANGE;
                }
                if (this[tmp.Row, tmp.Col - 1].Ch != ROAD_LETTER)
                {
                    return MoveStage.COLLISION;
                }
            }

            return MoveStage.OK;
        }

        public MoveStage IsCanMoveDown(Matrix m)
        {
            Point tmp;//will hold current point assigned in cycle. used for improoving performance ( - indexing operations )

            for (var i = 0; i < m.Rows; i++)
            {
                tmp = m[i, 0];
                if (tmp.Row >= this.Rows - 1)
                {
                    return MoveStage.OUT_OF_RANGE;
                }
                if (this[tmp.Row + 1, tmp.Col].Ch != ROAD_LETTER)
                {
                    return MoveStage.COLLISION;
                }
            }

            return MoveStage.OK;
        }

        //event handlers
        public EventHandler CarMovedLeftHandler()
        {
            return delegate(Object sender, EventArgs args)
            {
                Console.WriteLine("Event");
                var car = (sender as Car);
                var car_0 = car[0, 0];
                if (car_0.Col >= 0)
                {
                    car.EraseFrom(this);
                    car.MoveLeft();
                    car.WriteTo(this);
                }
            };
        }

        public EventHandler CarMoveRightHandler()
        {
            return delegate(Object sender, EventArgs args)
            {
                Car car = sender as Car;
                var car_0 = car[0, 0];

                if (car_0.Col < this.Cols)
                {
                    car.EraseFrom(this);
                    car.MoveRight();
                    car.WriteTo(this);
                }
            };
        }

        public EventHandler HollMoved()
        {
            return delegate(Object sender, EventArgs args)
            {
                var holl = (sender as Holl);
                var holl_0 = holl[0, 0];

                if (holl_0.Row < this.Rows)
                {
                    holl.EraseFrom(this);
                    holl.MoveDown();
                }
                else
                {
                    NeedNewHollEvent(this, args);
                }
            };
        }
    }
}