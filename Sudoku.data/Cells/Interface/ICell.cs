using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sudoku.data
{
    public interface ICell
    {
        CellState CellState { get; set; }
        
    }
}