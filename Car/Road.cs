using System;

namespace Car
{
    class Road: Matrix
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

            for (var i = 0; i < rows; i+=2)
            {
                matrix[i, c].Ch = ROAD_SEPARATOR;
            }
        }

        public void Move()
        {
            var c = Cols / 2;

            for (var i = 0; i < Rows; i ++)
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

        public bool IsCanMoveLeft(Matrix m)
        {
            Point a;// = new Point();
            for (var i = 0; i < m.Rows; i++)
            {
                a = m[i, 0];

                //if (a.Col > 0 && this.matrix[a.Row, a.Col] != a.Ch)
                //{

 //               }
            }

            return true;
        }


        //event handlers
        public EventHandler CarMovedLeftHandler()
        {
            return delegate(Object sender, EventArgs args)
            { 
                Console.WriteLine("Event");
                var car = (sender as Car);
                var car_0 = car[0, 0];
                if (car_0.Col >= 0 )
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