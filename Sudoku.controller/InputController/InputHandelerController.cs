using System;
using System.Collections.Generic;
using Sudoku.data;

namespace Sudoku.controller
{
    class InputHandlerController{

        public InputHandlerController(InputHandler _inputhandler, SudokuGameView _sudokuGameView)
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
            }while(!game.status.finished)
        }
    }
}
