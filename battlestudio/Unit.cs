using System;

namespace Battle
{
	abstract class Unit
	{
		protected string name;
		protected double life, power;
        protected bool isDied;

        protected string Sighn { get; set; }
       
		public Unit( string name, double power )
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
             Console.Write( this.name + " \a attacked " + target.Name  );
            if (!this.isDied && (this.Sighn != target.Sighn))
            {
                target.GetKick(this.power);

                if (target.Life <= 0)
                {
                    target.Die();
                }
                else
                {
                    Console.WriteLine(" and redused his life to " + target.Life);
                }           
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" but This is a friend");
                Console.ResetColor();
            }
		}
		
		public virtual void GetKick( double power )
		{
			this.life -= power;
		}		
		
		public void Die( )
		{
			Console.WriteLine( "The world lost " + this.Name );

            isDied = true;
		}
	}
}