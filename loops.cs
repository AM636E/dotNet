using System;

namespace Application
{
	class Loops
	{
		public static void Main()
		{
			try
			{
				int a = Convert.ToInt32( Console.ReadLine( ) );
				int b = Convert.ToInt32( Console.ReadLine( ) );
				
				for( ; a < b; a ++ )
				{
					Console.ForegroundColor = ConsoleColor.Red;
					
					for( int i = 0; i < a; i ++ )
					{
						Console.ForegroundColor = ConsoleColor.Green;
						Console.Write( a );
					}
					Console.Write( '\n' );
				}
				Console.ResetColor( );
			}
			catch(Exception e)
			{
				Console.WriteLine( e.Message );
				return;
			}			
		}		
	};
};