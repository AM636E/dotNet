using System;

namespace Battle
{
	abstract class One: Unit
	{
		protected string name;
		protected double life, power;
		
		
		One( string name, double power )
		{
			this.life = 100;
			this.name = name;
			this.power = power;
		}
		
		public string Name
		{
			get
			{
				return this.name;
			}
		}
		
		public double Life
		{
			get
			{
				return this.life;
			}
		}
		
		public double Power
		{
			get
			{
				return this.power;
			}
		}
		
		public void Beat( Unit target )
		{
			Console.WriteLine( this.name + " beat " + target.Name + " and redused his life to " + target.Life;  
		
			target.GetKick( this.power );
			
			if( target.Life <= 0 )
			{
				target.Die( );
			}
		}
		
		public virtual void GetKick( double power )
		{
			this.life -= power;
		}		
		
		public void Die( )
		{
			Console.WriteLine( "The world lost " + this.Name );
		}
	}
}