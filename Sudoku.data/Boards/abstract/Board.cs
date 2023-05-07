using Sudoku.data.Position;

namespace Sudoku.data.Boards;

//todo marijn make solver beter >:(
public abstract class Board : IBoard, solver, IObservable<IBoard>
{
    private ICollection<IObserver<IBoard>> observers;
    public uint NumberOfGroups { get; set; }
    public Pos _pos { get; }
    public List<List<Cell>> Cells { get; set; }
    public SudokuDisplayMode SudokuDisplayMode {get;}

    public SudokuTypes type {get;}

    protected Board(List<List<Cell>> cells, SudokuTypes type, SudokuDisplayMode sudokuDisplayMode)
    {
        Cells = cells;
        observers = new List<IObserver<IBoard>>();
        this.type = type;
        this.SudokuDisplayMode = sudokuDisplayMode;

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

    public void insert(uint nubmer)
    {
        throw new NotImplementedException();
    }
    public void Accept(ISudokuSolverVisitor visitor)
    {
        visitor.Visit(this);
    }
}

