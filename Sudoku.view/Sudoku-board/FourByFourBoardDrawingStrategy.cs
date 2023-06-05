using System;
using System.Collections.Generic;
using Sudoku.view.Cell;
using Sudoku.view.Sudoku_board.Abstract;
using Sudoku.data.Boards.@abstract;
using Sudoku.data.Cells;

namespace Sudoku.view.Sudoku_board
{
    public class FourByFourBoardDrawingStrategy : SudokuBoardView
    {
        public FourByFourBoardDrawingStrategy(Board board) : base(board)
        {
            Draw();
        }

public override void Draw()
{

    for (int row = 0; row < Size; row++)
    {
        for (int col = 0; col < Size; col++)
        {
            CellView cellView = GetCell(row, col);
            cellView.Draw();

            if (col == 1 )
            {
                Console.Write(" | ");
            }
        }
        Console.WriteLine();

        if (row == 1)
        {
            Console.WriteLine("-------");
        }
    }
} 
    }
}
