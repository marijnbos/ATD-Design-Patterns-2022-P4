using Sudoku.data.Boards.Enum;
using Sudoku.view.Cell;
using Sudoku.view.Sudoku_board.Abstract;
using Sudoku.view.Sudoku_board.Interface;

namespace Sudoku.view.Sudoku_board.Factory;

public abstract class CreatorViewBoard
{
    public abstract SudokuBoardView factorMethod(SudokuDisplayMode displayoptions, SudokuTypes type, List<List<CellView>> cells);
}