using System;
using System.Collections;

namespace Battle
{
	class Human: Unit, IRace
	{
        public enum Armor
        {
            KNIFE = 10,
            GUN   = 20,
            SWORD = 30
        };
        
		private int luckyness;
		
		public Human( string name, double power ):
            base("Human " + name, power) { luckyness = 80; Sighn = "Human"; }
			
		public override void GetKick( double power )
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