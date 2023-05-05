namespace Sudoku.view.GameView;

public class SudokuGameView : IView
{
    private readonly SudokuBoardView _sudokuBoardView;
    public SudokuGameView(SudokuBoardView sudokuBoardView)
    {
        _sudokuBoardView = sudokuBoardView;
    }
    
    public void Draw()
    {
        _sudokuBoardView.Draw();
    }
}