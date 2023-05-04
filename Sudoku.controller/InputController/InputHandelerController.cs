using System;
using System.Collections.Generic;
using Sudoku.data;

namespace Sudoku.controller
{
    public class InputHandelerController : IController, IObservable<PlayerInput>
    {
        private ICollection<IObserver<PlayerInput>> observers;
        public InputHandelerController()
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

        
        private PlayerInput GetPlayerInput(string? key)
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
