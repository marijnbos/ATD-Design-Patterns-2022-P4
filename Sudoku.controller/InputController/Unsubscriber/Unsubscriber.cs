using Sudoku.data;

namespace Sudoku.controller.Unsubscriber;

public class Unsubscriber : IDisposable
{
    private ICollection<IObserver<PlayerInput>> observers;
    private IObserver<PlayerInput> observer;

    public Unsubscriber(ICollection<IObserver<PlayerInput>> observers, IObserver<PlayerInput> observer)
    {
        this.observers = observers;
        this.observer = observer;
    }

    public void Dispose()
    {
        if (observers.Contains(observer))
            observers.Remove(observer);
    }
}