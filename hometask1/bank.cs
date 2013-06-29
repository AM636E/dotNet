using System;

namespace Application
{
    class Bank
    {
        public static void Main()
        {
            const double START_VAL = 1000;
            const double MAX_VAL = 1100;
            double p = 0;
            double n = 0;
            try
            {
            
                p = Convert.ToDouble(Console.ReadLine());
            
                double logBase = 1 + p / 100;
            
                Console.WriteLine(Math.Log(MAX_VAL, (1 + p / 100)));
                Console.WriteLine(Math.Log(START_VAL, (1 + p / 100)));
                n = Math.Ceiling(Math.Log(MAX_VAL, (1 + p / 100))) - Math.Ceiling(Math.Log(START_VAL, (1 + p / 100)));
            
                Console.WriteLine(n);
            
                //   Console.WriteLine(Math.Log(4, 2));
                //////////////////////////
                p /= 100;
                int months = 0;
                for (double i = START_VAL; i < MAX_VAL; i = (i + i * p))
                {
                    months++;
                }
            
                System.Console.WriteLine(months);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            
                return;
            }          
        }
    };
};