using System;

namespace Car
{
    static class Game
    {
        private static Car car;
        private static Road road;
        private static Holl holl;

        static Game()
        {
            car = new Car(5, 5);
            road = new Road(10, 21);
            holl = new Holl(0, 0);
        }

        private static void MoveRoad()
        {
        }
        //we can send restorer
        public static void Start()
        {
            road.RoadMoved += holl.RoadMoveHandler();
            car.MoveLeftEvent += road.CarMovedLeftHandler();
            car.MoveRightEvent += road.CarMoveRightHandler();

            car.WriteTo(road);
            holl.WriteTo(road);

            car.MoveLeftEvent(car, EventArgs.Empty);
            
            while (true)
            {
                road.Print();
                road.Move();

                System.Threading.Thread.Sleep(50);
            }


        }
    }
}
