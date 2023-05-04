using Sudoku.controller;
using Sudoku.data;

namespace Sudoku.controler.EditorController
{
    public class EditorController : IObserver<PlayerInput>
    {
        InputHandelerController InputHandelerController { get; set; }
        public EditorController(InputHandelerController inputHandelerController)
        {
            InputHandelerController = inputHandelerController;
            InputHandelerController.Subscribe(this);
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
        //  InputHandelerController.WaitForAction();
        }
    }
}