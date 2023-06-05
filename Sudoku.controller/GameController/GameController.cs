using Sudoku.controler.InputController;
using Sudoku.data.Game;
using Sudoku.view.GameView;
using Sudoku.data.Game.Enum;

namespace Sudoku.controler.GameController
{
    public class GameController{
        public InputHandlerController InputHandler {get;}
        public SudokuGameView SudokuGameView {get;}
        public GameContext Game {get;}

        public GameController(InputHandlerController inputhandler, SudokuGameView sudokuGameView, GameContext game)
        {
            this.InputHandler = inputhandler;
            this.SudokuGameView = sudokuGameView;
            this.Game = game;
        }

        public void gameLoop()
        {
            try
            {
                do{
                    InputHandler.SetPlayerInput(SudokuGameView.GetPlayerInput());
                    SudokuGameView.ProcessData(Game);
                    SudokuGameView.Draw();
                
                    //update views
                }while(Game.GameStatus == GameStatus.Ongoing);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }
    }
}