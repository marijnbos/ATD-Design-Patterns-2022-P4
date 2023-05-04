using System;
using System.Collections.Generic;
using Sudoku.data;

namespace Sudoku.controller
{
    public class InputController : IController, IObservable<PlayerInput>
    {
        private ICollection<IObserver<PlayerInput>> observers;
        public InputController()
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
        public void WaitForAction()
        {
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine(key.KeyChar);
            NotifyObserversOfAction(GetPlayerInput(key));
        }
        
        private PlayerInput GetPlayerInput(ConsoleKeyInfo key)
        {
            //only key is used, but could be extended to include modifiers\mouse position etc
            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    return PlayerInput.up;
                case ConsoleKey.DownArrow:
                    return PlayerInput.down;
                case ConsoleKey.LeftArrow:
                    return PlayerInput.left;
                case ConsoleKey.RightArrow:
                    return PlayerInput.right;
                case ConsoleKey.Escape:
                    return PlayerInput.select;
                case ConsoleKey.S:
                    return PlayerInput.save;
                case ConsoleKey.L:
                    return PlayerInput.load;
                case ConsoleKey.G:
                    return PlayerInput.generate;
                case ConsoleKey.O:
                    return PlayerInput.solve;
                case ConsoleKey.Q:
                    return PlayerInput.quit;
                default:
                    return PlayerInput.none;
            }
        }
    }
}
