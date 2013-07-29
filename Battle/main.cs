using System;

namespace Battle
{
	class Program
	{
		static void Main( )
		{
			Human hKing 	 = new Human( "King"     , 25 );//name power
			Human hWarrior 	 = new Human( "Warrior"  , 15 );
			Human hMagician  = new Human( "Magician" , 20 );
			Human hLancer	 = new Human( "Lancer"   , 18 );
		
			Alien aKing		 = new Alien( "King"		, 25 );
			Alien aWarrior   = new Alien( "Warrior"  , 15 );
			Alien aMagician  = new Alien( "Magician" , 20 );
			
			hKing.Beat( aKing );
		}
	}
}