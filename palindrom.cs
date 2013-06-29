using System;

namespace Application
{
	class Palindrom
	{
		public static void Main() 
		{
			string input = Console.ReadLine( );
			int a = 0;
			if( !Int32.TryParse( input, out a ) )
			{
				return;
			}
			
			char[] arr = input.ToCharArray( );
			
			Array.Reverse( arr );
			
			Console.WriteLine( arr );
		}
	};	
};