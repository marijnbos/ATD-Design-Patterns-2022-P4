using Sudoku.controller;
using Sudoku.data;
using Sudoku.data.Game;
using Sudoku.view.GameView;

namespace Sudoku.controler
{
    class GameController{
        public InputHandlerController InputHandler {get;}
        public SudokuGameView SudokuGameView {get;}
        public GameContext Game {get;}

        public GameController(InputHandlerController _inputhandler, SudokuGameView _sudokuGameView, GameContext _game)
        {
            this.InputHandler = _inputhandler;
            this.SudokuGameView = _sudokuGameView;
            this.Game = _game;
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