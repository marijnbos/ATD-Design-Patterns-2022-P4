using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sudoku.data
{
    public enum CellState
    {
        faultyCell,
        filledSystem,
        filledUser,
        empty,
        //todo check this
        notACell
    }
}