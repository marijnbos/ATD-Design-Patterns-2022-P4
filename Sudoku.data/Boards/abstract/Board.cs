using Sudoku.data.Position;

namespace Sudoku.data.Boards;

//todo marijn make solver beter >:(
public abstract class Board : IBoard, solver, IObservable<IBoard>
{
    private ICollection<IObserver<IBoard>> observers;
    public uint NumberOfGroups { get; set; }
    public Pos _pos { get; }
    public List<List<Cell>> Cells { get; set; }
    protected Board(List<List<Cell>> cells)
    {
        Cells = cells;
        observers = new List<IObserver<IBoard>>();
    }
    public abstract Board getSolvedBoard();
    public abstract Board validateBoard();
    public abstract IBoard copy();
 
    
    public IDisposable Subscribe(IObserver<IBoard> observer)
    {
        observers.Add(observer);
        return new Unsubscriber.Unsubscriber(observers, observer);
    }
    public abstract void move(Pos move);
}

