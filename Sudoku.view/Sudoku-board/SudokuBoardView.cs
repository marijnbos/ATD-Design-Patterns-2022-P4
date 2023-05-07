using Sudoku.view.Cell;
namespace Sudoku.view;

public abstract class SudokuBoardView : IView
{
    List<List<CellView>> cells {get;set;}
    string _displayoptions;
    public SudokuBoardView(string displayoptions, string type, List<List<CellView>> cells)
    {
        _displayoptions = displayoptions;
        this.cells = cells;
        //display the board
    }   

    public void Draw()
    {
        // foreach (var cell in _Cells)
        // {
        //     cell.Draw();
        // }
    }
}