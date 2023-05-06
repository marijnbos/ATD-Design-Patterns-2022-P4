using Sudoku.data;
using Sudoku.data.Game;
using Sudoku.view.GameView;

namespace Sudoku.controler
{
    class GameController{
        public InputHandler InputHandler {get;}
        public SudokuGameView SudokuGameView {get;}

        public GameController(InputHandler _inputhandler, SudokuGameView _sudokuGameView)
        {
            this.InputHandler = _inputhandler;
            this.SudokuGameView = _sudokuGameView;
        }

        public void gameLoop()
        {
            do{
            //get JSON data from view
            //inputhandler
            //game logic takes places all over
            //update views
            }while(!game.status.finished);
        }
    }
}