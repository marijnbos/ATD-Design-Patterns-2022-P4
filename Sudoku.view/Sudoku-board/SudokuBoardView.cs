using Sudoku.data.Boards;

namespace Sudoku.view;

public class SudokuBoardView : IView
{
    
    string _displayoptions;
    public SudokuBoardView(string displayoptions)
    {
        _displayoptions = displayoptions;
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