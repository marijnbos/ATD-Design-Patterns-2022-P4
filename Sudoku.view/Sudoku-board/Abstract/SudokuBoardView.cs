using Sudoku.data.Boards.Enum;
using Sudoku.view.Cell;

namespace Sudoku.view.Sudoku_board.Abstract;

public abstract class SudokuBoardView : IView
{
    public List<List<CellView>> Cells { get; set; }
    public SudokuDisplayMode Displayoptions;

    public SudokuBoardView(SudokuDisplayMode displayoptions, string type, List<List<CellView>> cells)
    {
        Displayoptions = displayoptions;
        Cells = cells;
        //display the board
    }

    public abstract void Draw();
}