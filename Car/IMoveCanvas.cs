using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Car
{
    enum MoveStage
    {
         OK,
         COLLISION,
         OUT_OF_RANGE
    };
    interface IMoveCanvas
    {
        MoveStage IsCanMoveLeft(Matrix m);
        MoveStage IsCanMoveRight(Matrix m);
        MoveStage IsCanMoveDown(Matrix m);
    }
}
