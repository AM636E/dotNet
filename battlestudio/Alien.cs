using System;

namespace Battle
{
	class Alien: Unit, IRace
	{
		public Alien( string name, double power ):
            base("Alien " + name, power + 20) { this.Sighn = "Alien"; }
			
		public override void GetKick( double power )
		{
			this.life -= power;
		}		
	}
}