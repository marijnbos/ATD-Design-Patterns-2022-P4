using Sudoku.data;

namespace Sudoku.controller;

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

    private PlayerInput ProcessInput(ConsoleKeyInfo key)
    {
        //only key is used, but could be extended to include modifiers\mouse position etc
        return key.Key switch
        {
            ConsoleKey.UpArrow => PlayerInput.up,
            ConsoleKey.DownArrow => PlayerInput.down,
            ConsoleKey.LeftArrow => PlayerInput.left,
            ConsoleKey.RightArrow => PlayerInput.right,
            // d1 -> nu kan je input voor je square geven
            ConsoleKey.Escape => PlayerInput.select,
            ConsoleKey.S => PlayerInput.save,
            ConsoleKey.L => PlayerInput.load,
            ConsoleKey.G => PlayerInput.generate,
            ConsoleKey.O => PlayerInput.solve,
            ConsoleKey.Q => PlayerInput.quit,
            _ => PlayerInput.none
        };
    }
}