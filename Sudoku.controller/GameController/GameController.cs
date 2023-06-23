using Sudoku.controler.InputController;
using Sudoku.data.Game;
using Sudoku.data.Game.Enum;
using Sudoku.view.GameView;

namespace Sudoku.controler.GameController;

public class GameController
{
    public InputHandlerController InputHandler { get; }
    public SudokuGameView SudokuGameView { get; }
    public GameContext Game { get; }

    public GameController(InputHandlerController inputhandler, SudokuGameView sudokuGameView, GameContext game)
    {
        InputHandler = inputhandler;
        SudokuGameView = sudokuGameView;
        Game = game;
    }

    public void gameLoop()
    {
        try
        {
            do
            {
                InputHandler.SetPlayerInput(SudokuGameView.GetPlayerInput());
                Game.UpdateGameStatus();
                SudokuGameView.ProcessData(Game);
                SudokuGameView.Draw();
            } while (Game.GameStatus == GameStatus.Ongoing);
        }
        catch (Exception e)
        {
            throw;
        }

        SudokuGameView.PrintGameOver();
    }
}