using Sudoku.data.Boards.@abstract;
using Sudoku.view.Cell;
using Sudoku.view.Sudoku_board.Abstract;

namespace Sudoku.view.Sudoku_board;

public class FourByFourBoardDrawingStrategy : SudokuBoardView
{
    public FourByFourBoardDrawingStrategy(Board board) : base(board)
    {
        Draw();
    }

    public override void Draw()
    {
        for (var row = 0; row < Size; row++)
        {
            for (var col = 0; col < Size; col++)
            {
                var cellView = GetCell(row, col);
                cellView.Draw();

                if (col == 1) Console.Write(" | ");
            }

            Console.WriteLine();

            if (row == 1) Console.WriteLine("-------");
        }
    }
}