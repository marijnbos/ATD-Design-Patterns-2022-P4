using Sudoku.data;
using Sudoku.data.Game;
using Sudoku.data.Input.Enum;

namespace Sudoku.controler.InputController
{
    public class InputHandlerController: IController, IObservable<PlayerInput>{
        public GameContext Game {get;} 
        private readonly ICollection<IObserver<PlayerInput>> _observers;

        public InputHandlerController(GameContext game)
        {
            this.Game = game;
            _observers = new List<IObserver<PlayerInput>>();
        }
        public IDisposable Subscribe(IObserver<PlayerInput> observer)
        {
            _observers.Add(observer);
            return new Unsubscriber.Unsubscriber(_observers, observer);
        }

        private void NotifyObserversOfAction(PlayerInput action)
        {
            foreach (IObserver<PlayerInput> observer in _observers) observer.OnNext(action);
        }

        
        public PlayerInput GetPlayerInput(string key)
        {
           // here player input is processed
            switch (key)
            {
                default:
                    return PlayerInput.None;
            }
        }
    }
}
