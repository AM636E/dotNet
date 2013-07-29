using System;

namespace Battle
{
	class Alien: One
	{
		Alien( string name, double power ):
			base( "Alien " + name, power + 20 ){}
			
		public void GetKick( double power )
		{
			this.life -= power;
		}		
	}
}