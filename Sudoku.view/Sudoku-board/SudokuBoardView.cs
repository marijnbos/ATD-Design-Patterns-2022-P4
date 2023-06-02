using Sudoku.view.Cell;

namespace Sudoku.view.Sudoku_board;

public abstract class SudokuBoardView : IView
{
    List<List<CellView>> Cells {get;set;}
    string _displayoptions;
    public SudokuBoardView(string displayoptions, string type, List<List<CellView>> cells)
    {
        _displayoptions = displayoptions;
        Cells = cells;
        //display the board
    }

    public abstract void Draw();
}