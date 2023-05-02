using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sudoku.controller;
using Sudoku.data;

namespace Sudoku.controler
{
    public class EditorController : IObserver<PlayerInput>
    {
        InputController inputController { get; set; }

        public EditorController()
        {
            inputController = new InputController();
            inputController.Subscribe(this);
        }


        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(PlayerInput value)
        {
          inputController.ProcessInput(value);
        }
    }
}