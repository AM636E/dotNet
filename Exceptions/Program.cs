using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    if (Console.ReadLine().IndexOfAny(",.;".ToCharArray()) != -1)
                    {
                        throw new UserEnterAPunctiacialException("Wrong input data. You should be ashamed");
                    }
                }
            }
            catch( UserEnterAPunctiacialException e )
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
