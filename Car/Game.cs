using System;

namespace Car
{
    static class Game
    {
        private static Car car;
        private static Road road;
        private static Holl holl;

        //events
        public static event EventHandler LeftKeyPressed;
        public static event EventHandler RightKeyPressed;

        static Game()
        {
            car = new Car(5, 5);
            road = new Road(10, 21);
            holl = new Holl(10, 0);
        }

        private static void MoveRoad()
        {
        }
       
        public static void Start()
        {
            car.WriteTo(road);
            road.RoadMoved += RoadMoveHandler();
            LeftKeyPressed += LeftKeyPressedHandler();
            RightKeyPressed += RightKeyPressedHandler();

            while (true)
            {
                switch (Console.ReadKey().KeyChar)
                {
                    case 'a':
                    case 'A':
                        {
                            LeftKeyPressed(car, EventArgs.Empty);

                            break;
                        }
                    case 'd':
                    case 'D':
                        {
                            RightKeyPressed(car, EventArgs.Empty);

                            break;
                        }
                }

                road.Move(); 
                road.Print();                               
            }
        }

        public static EventHandler RoadMoveHandler()
        {
            return delegate ( object sender, EventArgs args )
            {
                var road = sender as Road;
                
                MoveStage moveStage = road.IsCanMoveDown(holl);// as MoveStage;

                switch( moveStage )
                {
                    case MoveStage.OK:
                        {
                            holl.EraseFrom(road);
                            holl.MoveDown();
                            holl.WriteTo(road);

                            break;
                        }
                    case MoveStage.COLLISION:
                        {
                            //break the car or something similar

                            break;
                        }
                    case MoveStage.OUT_OF_RANGE:
                        {
                            holl.EraseFrom(road);
                            var rnd = new Random();
                            var tmp = car[0, 0];

                            holl = new Holl( rnd.Next(0, tmp.Row - 1), rnd.Next(0, road.Cols - 1) );
                        //    holl.WriteTo(road);
                            break;
                        }
                }
               
            };
        }

        public static EventHandler LeftKeyPressedHandler()
        {
            return delegate( Object sender, EventArgs args )
            {
                var car = sender as Car;

                var moveStage = road.IsCanMoveLeft(car);

                switch (moveStage)
                {
                    case MoveStage.OK:
                        {
                            car.EraseFrom(road);
                            car.MoveLeft();
                            car.WriteTo(road);

                            break;
                        }
                    case MoveStage.COLLISION:
                        {
                            //car.EraseFrom(road);
                            break;
                        }
                    case MoveStage.OUT_OF_RANGE:
                        {
                            break;
                        }
                }
            };
        }

        public static EventHandler RightKeyPressedHandler()
        {
            return delegate(Object sender, EventArgs args)
            {
                var car = sender as Car;

                var moveStage = road.IsCanMoveRight(car);

                switch (moveStage)
                {
                    case MoveStage.OK:
                        {
                            car.EraseFrom(road);
                            car.MoveRight();
                            car.WriteTo(road);

                            break;
                        }
                    case MoveStage.COLLISION:
                        {
                            //car.EraseFrom(road);
                            break;
                        }
                    case MoveStage.OUT_OF_RANGE:
                        {
                            break;
                        }
                }
            };
        }
    }
}