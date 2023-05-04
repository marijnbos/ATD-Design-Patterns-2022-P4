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
          // activate the next step after beeing called by the input controller
          inputController.WaitForAction();
        }
    }
}