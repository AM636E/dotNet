using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exceptions
{
    interface ISimpleNAngle
    {
        double Height { get; set; }
        double Down { get; set; }
        double Alpha { get; set; }
        int N { get; set; }
        double[] Sides { get; set; }
        double Square { get; }
        double Perimetr { get; }
    }
}
