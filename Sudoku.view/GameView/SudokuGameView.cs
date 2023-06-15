using Sudoku.data.Game;
using Sudoku.view.StrategyConsoleWrapper;
using Sudoku.view.Sudoku_board.Abstract;

namespace Sudoku.view.GameView;

public class SudokuGameView : IView
{
    private readonly SudokuBoardView _sudokuBoardView;
    private readonly IConsoleWrapper _consoleWrapper;
    public string EditorState { get; set; }
    public SudokuGameView(GameContext gc, SudokuBoardView sudokuBoardView, IConsoleWrapper consoleWrapper)
    {
        EditorState = gc.EditorState.ToString();
        //Console.CursorVisible = false;
        
       
        _sudokuBoardView = sudokuBoardView;
        _consoleWrapper = consoleWrapper;
        Draw();
    }

    public void ProcessData(GameContext gc)
    {
        _sudokuBoardView.ProcessData(gc.Board);
        EditorState = gc.EditorState.ToString();
    }

    public void Draw()
    {
        _consoleWrapper.Clear();
        _sudokuBoardView.Draw();
        PrintGameInfo();
    }

    public void PrintGameInfo()
    {
        Console.WriteLine("Editor state: " + EditorState);
    }

    public void PrintGameOver()
    {
        Console.WriteLine("Game Over...");
    }

    public string GetPlayerInput()
    {
        var key = Console.ReadKey().Key;
        string input;

        if (key >= ConsoleKey.D1 && key <= ConsoleKey.D9)
            input = ((char)key).ToString();
        else
            input = key.ToString().ToUpper();

        return input;
    }


}