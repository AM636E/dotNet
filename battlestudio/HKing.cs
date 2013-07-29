using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Battle
{
    class HKing: Human, IRace
    {
       public HKing() :
            base("King", 25) { }            
    }
}
