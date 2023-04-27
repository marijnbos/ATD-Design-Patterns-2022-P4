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
            ConsoleKey.D1 => PlayerInput.one,
            ConsoleKey.D2 => PlayerInput.two,
            ConsoleKey.D3 => PlayerInput.three,
            ConsoleKey.D4 => PlayerInput.four,
            ConsoleKey.D5 => PlayerInput.five,
            ConsoleKey.D6 => PlayerInput.six,
            ConsoleKey.D7 => PlayerInput.seven,
            ConsoleKey.D8 => PlayerInput.eight,
            ConsoleKey.D9 => PlayerInput.nine,
            ConsoleKey.S => PlayerInput.save,
            ConsoleKey.L => PlayerInput.load,
            ConsoleKey.G => PlayerInput.generate,
            ConsoleKey.O => PlayerInput.solve,
            ConsoleKey.Q => PlayerInput.quit,
            _ => PlayerInput.none
        };
    }
}