namespace Sudoku.data.Boards.Unsubscriber;

public class Unsubscriber : IDisposable
{
    private ICollection<IObserver<IConcreteBoard>> observers;
    private IObserver<IConcreteBoard> observer;

    public Unsubscriber(ICollection<IObserver<IConcreteBoard>> observers, IObserver<IConcreteBoard> observer)
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