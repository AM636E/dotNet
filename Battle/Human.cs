using System;

namespace Battle
{
	class Human: One
	{
		private int luckyness;
		
		public Human( string name, double power ):
			base( "Human " + name, power ){ luckyness = 80; }
			
		public void GetKick( double power )
		{
			Random luck = new Random( );
			
			if( luck.Next( 0, 100 ) > luckyness )
			{
				this.life -= power;
				
				return;
			}
			
			Console.WriteLine( this.name + " get out" );
		}
	}
}