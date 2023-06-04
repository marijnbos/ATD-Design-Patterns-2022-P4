using Sudoku.controler.InputController;
using Sudoku.data.Game;
using Sudoku.view.GameView;

namespace Sudoku.controler.GameController
{
   public class GameController{
        public InputHandlerController InputHandler {get;}
        public SudokuGameView SudokuGameView {get;}
        public GameContext Game {get;}

        public GameController(InputHandlerController inputhandler, SudokuGameView sudokuGameView, GameContext game)
        {
            InputHandler = inputhandler;
            SudokuGameView = sudokuGameView;
            Game = game;
        }

        public void gameLoop()
        {
            /*
            do{
            //get JSON data from view
            //inputhandler
            //game logic takes places all over
            //update views
            }while(!game.status.finished);
            */
        }
    }
}