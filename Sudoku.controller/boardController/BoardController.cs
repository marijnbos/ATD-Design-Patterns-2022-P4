using Sudoku.data.Boards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sudoku.controler.Strategy;
using Sudoku.view.GameView;

namespace Sudoku.controler
{
    public class BoardController
    {
        SudokuTypes sudokuTypes { get; set; }
        
        public BoardController(ConcreteBoardStrategy concreteBoardStrategy)
        {
            throw new NotImplementedException();
        }
        public void solve()
        {
            throw new NotImplementedException();
        }
    }
}