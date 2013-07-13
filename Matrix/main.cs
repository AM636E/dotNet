using System;

namespace Application
{
  class Program
	{
        static void f( )   
        {
            throw new Exception("f()");          
        }

        static void f1()
        {
            f();
        }

        static void a()
        {
            try
            {
                f1();
            }
            catch (Exception e)
            {
                Console.WriteLine("StackTrace: {0}", e.StackTrace);
                Console.WriteLine("Data: {0}", e.Data);
                Console.WriteLine("Help Link: {0}", e.HelpLink);
                Console.WriteLine("Inner Exception: {0}", e.InnerException);
                Console.WriteLine("Source: {0}", e.Source);
                Console.WriteLine("Target size: {0}", e.TargetSite);
                //Console.WriteLine("a: {0}", e.ToString( ));
            }
        }

        static void Print(Byte a)
        {
            System.ValueType
        }
         
		static void Main( )
		{
            

            Console.WriteLine(new int[2] { 1, 2 }.GetHashCode());
        }
	}
};