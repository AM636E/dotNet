using System;

namespace Application
{
	class Hello
	{
		public static void Main( )
		{
			Console.WriteLine( "Enter width and height of rectangle" );
			try
			{
				 int a = Convert.ToInt32( System.Console.ReadLine( ) ),
				 b = Convert.ToInt32( System.Console.ReadLine( ) ),
				 c = Convert.ToInt32( System.Console.ReadLine( ) );
				
				 int squares = ( ( a / c ) * ( b / c ) );
				 
				 Console.ForegroundColor = ConsoleColor.Red;
				 if( squares == 0 )
				 {
					Console.WriteLine( "No square can be filled in rectangle" ) ;
					Console.ResetColor( );
					return ;
				 }
				 
				 System.Console.WriteLine( "Filled squares: " + squares );
				 
				 Console.ForegroundColor = ConsoleColor.Green;
				 System.Console.WriteLine( "Avaliable space: " + ( a * b - ( c * c * squares ) ) );

				 Console.ResetColor( );
			 }
			 catch( Exception e )
			 {
				Console.WriteLine( e.Message );
			 }			
		}		
	}
};
