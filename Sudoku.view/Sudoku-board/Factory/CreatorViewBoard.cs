using Sudoku.data.Boards.@abstract;
using Sudoku.view.Sudoku_board.Abstract;

namespace Sudoku.view.Sudoku_board.Factory;

public abstract class CreatorViewBoard
{
    public abstract SudokuBoardView factorMethod(Board board);
}