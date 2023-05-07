namespace Sudoku.data.Boards.Unsubscriber;

public class Unsubscriber : IDisposable
{
    private ICollection<IObserver<IBoard>> observers;
    private IObserver<IBoard> observer;

    public Unsubscriber(ICollection<IObserver<IBoard>> observers, IObserver<IBoard> observer)
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