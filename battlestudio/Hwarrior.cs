using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Battle
{
    class HWarrior: Human, IRace
    {
       public HWarrior() :
            base("Warrior", 23) { }
    }
}
