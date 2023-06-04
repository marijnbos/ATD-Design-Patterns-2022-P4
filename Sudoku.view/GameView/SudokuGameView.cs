using Sudoku.view.Sudoku_board;
using Sudoku.view.Sudoku_board.Abstract;

namespace Sudoku.view.GameView;

public class SudokuGameView : IView
{
    private readonly SudokuBoardView _sudokuBoardView;

    public SudokuGameView(SudokuBoardView sudokuBoardView)
    {
        _sudokuBoardView = sudokuBoardView;
    }

    public void ProcessData(string input)
    {
        throw new NotImplementedException();
    }

    public void Draw()
    {
        _sudokuBoardView.Draw();
    }
}