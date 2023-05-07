using System;
using System.Collections.Generic;
using Sudoku.data;
using Sudoku.data.Game;

namespace Sudoku.controller
{
    class InputHandlerController: IController, IObservable<PlayerInput>{
        public GameContext game {get;} 
        private ICollection<IObserver<PlayerInput>> observers;

        public InputHandlerController(GameContext game)
        {
            observers = new List<IObserver<PlayerInput>>();
        }
        public IDisposable Subscribe(IObserver<PlayerInput> observer)
        {
            observers.Add(observer);
            return new Unsubscriber.Unsubscriber(observers, observer);
        }

        private void NotifyObserversOfAction(PlayerInput action)
        {
            foreach (IObserver<PlayerInput> observer in observers) observer.OnNext(action);
        }

        
        public PlayerInput GetPlayerInput(string key)
        {
           // here player input is processed
            switch (key)
            {
                default:
                    return PlayerInput.none;
            }
        }
    }
}
