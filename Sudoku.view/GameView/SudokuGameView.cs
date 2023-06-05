using Sudoku.data.Game;
using Sudoku.view.Sudoku_board;
using Sudoku.view.Sudoku_board.Abstract;
using System.Text.Json;

namespace Sudoku.view.GameView;

public class SudokuGameView : IView
{
    private readonly SudokuBoardView _sudokuBoardView;
    public string EditorState {get;set;}
    public SudokuGameView(GameContext gc, SudokuBoardView sudokuBoardView)
    {
        EditorState = gc.EditorState.ToString();
        Console.CursorVisible = false;
        _sudokuBoardView = sudokuBoardView;
    }

    public void ProcessData(GameContext gc)
    {
        _sudokuBoardView.ProcessData(gc.Board);
        EditorState = gc.EditorState.ToString();
    }
    
    public void Draw()
    {
        Console.Clear();
        _sudokuBoardView.Draw();
        PrintGameInfo();
    }

    public void PrintGameInfo()
    {
        Console.WriteLine("Editor state: " + EditorState);
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