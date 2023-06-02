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

    protected Board(string inputCells, SudokuTypes type, SudokuDisplayMode sudokuDisplayMode)
    {
        _observers = new List<IObserver<IConcreteBoard>>();
        Type = type;
        SudokuDisplayMode = sudokuDisplayMode;
        Cells = CreateBoard(inputCells);
    }
    public abstract Board getSolvedBoard();
    public abstract Board validateBoard();
    public abstract IConcreteBoard copy();
    public abstract List<List<ProductCell>> CreateBoard(string cells);
 
    
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

