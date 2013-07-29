using System;

namespace Battle
{
	interface Unit
	{
		string Name { get; }
		double Life{ get; }
		double Power{ get; }
		
		void Beat( Unit target );
		void GetKick( double power );
		
		void Die();
	}
}
