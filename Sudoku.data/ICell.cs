using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sudoku.data
{
    public interface Cell
    {
        CellState CellState { get; set; }
    }
}