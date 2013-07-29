using System;

namespace Battle
{
    class Program
    {
        enum A
        {k = 10, b = 20}

        static void Main()
        {
            Unit[] a = new Unit[100];

            for (var i = 0; i < 100; i += 4)
            {
                a[i] = new HKing();
                a[i + 1] = new HWarrior();
                a[i + 2] = new AKing();
                a[i + 3] = new AWarrior();
            }



            for (var i = 0; i < 100; i++)
            {
                for (var j = 0; j < 100; j++)
                {
                    a[i].Beat(a[j]);
                    Console.ReadKey();
                }
            }

        }
    }
}