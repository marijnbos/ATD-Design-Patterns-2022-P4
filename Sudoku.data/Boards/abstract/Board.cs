using Sudoku.data.Boards.Enum;
using Sudoku.data.Boards.Interface;
using Sudoku.data.Cells.@abstract;
using Sudoku.data.Position;

namespace Sudoku.data.Boards.@abstract;

//todo marijn make solver beter >:(
public abstract class Board : IConcreteBoard, ISolver, IObservable<IConcreteBoard>
{
    private ICollection<IObserver<IConcreteBoard>> _observers;
    public uint NumberOfGroups { get; set; }
    public List<List<ProductCell>> Cells { get; set; }
    public SudokuDisplayMode SudokuDisplayMode {get;}

    public SudokuTypes Type {get;}

    protected Board(List<List<ProductCell>> cells, SudokuTypes type, SudokuDisplayMode sudokuDisplayMode)
    {
        Cells = cells;
        _observers = new List<IObserver<IConcreteBoard>>();
        Type = type;
        SudokuDisplayMode = sudokuDisplayMode;

    }
    public abstract Board getSolvedBoard();
    public abstract Board validateBoard();
    public abstract IConcreteBoard copy();
 
    
    public IDisposable Subscribe(IObserver<IConcreteBoard> observer)
    {
        _observers.Add(observer);
        return new Unsubscriber.Unsubscriber(_observers, observer);
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

