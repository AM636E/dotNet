using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Battle
{
    class AKing: Alien, IRace
    {
        public AKing() :
            base("King", 30) { }
    }
}
