using Sudoku.data.Position;

namespace Sudoku.data.Boards;

//todo marijn make solver beter >:(
public abstract class Board : IConcreteBoard, ISolver, IObservable<IConcreteBoard>
{
    private ICollection<IObserver<IConcreteBoard>> observers;
    public uint NumberOfGroups { get; set; }
    public Pos _pos { get; }
    public List<List<ProductCell>> Cells { get; set; }
    public SudokuDisplayMode SudokuDisplayMode {get;}

    public SudokuTypes type {get;}

    protected Board(List<List<ProductCell>> cells, SudokuTypes type, SudokuDisplayMode sudokuDisplayMode)
    {
        Cells = cells;
        observers = new List<IObserver<IConcreteBoard>>();
        this.type = type;
        this.SudokuDisplayMode = sudokuDisplayMode;

    }
    public abstract Board getSolvedBoard();
    public abstract Board validateBoard();
    public abstract IConcreteBoard copy();
 
    
    public IDisposable Subscribe(IObserver<IConcreteBoard> observer)
    {
        observers.Add(observer);
        return new Unsubscriber.Unsubscriber(observers, observer);
    }
    public abstract void move(Pos move);

    public void insert(uint nubmer)
    {
        throw new NotImplementedException();
    }
    public void Accept(ISudokuSolverVisitor visitor)
    {
        visitor.Visit(this);
    }
}

