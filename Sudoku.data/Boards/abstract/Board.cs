using Sudoku.data.Boards.Enum;
using Sudoku.data.Boards.Interface;
using Sudoku.data.Cells.@abstract;
using Sudoku.data.Position;
using Sudoku.data.Input.Enum;

namespace Sudoku.data.Boards.@abstract;

public abstract class Board : IConcreteBoard, ISolver, IObservable<IConcreteBoard>, IObserver<PlayerInput>
{
    private ICollection<IObserver<IConcreteBoard>> _observers;
    public uint NumberOfGroups { get; set; }
    public List<List<ProductCell>> Cells { get; set; }
    public SudokuDisplayMode SudokuDisplayMode {get;}

    public SudokuTypes Type {get;}
    public Pos SelectedCell {get; set;}

    public int Size { get { return Cells.Count; } }

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
    
    public void Accept(ISudokuSolverVisitor visitor)
    {
        visitor.Visit(this);
    }
    public ProductCell GetCell(int row, int column)
    {
        return Cells[row][column];
    }

    public void OnCompleted()
    {
        throw new NotImplementedException();
    }

    public void OnError(Exception error)
    {
        throw new ArgumentOutOfRangeException(error.ToString());
    }
    public void OnNext(PlayerInput value)
{
    switch (value)
    {
        case PlayerInput.Up:
            move(new Pos(0, -1));
            break;

        case PlayerInput.Left:
            move(new Pos(-1, 0));
            break;

        case PlayerInput.Down:
            move(new Pos(0, 1));
            break;

        case PlayerInput.Right:
            move(new Pos(1, 0));
            break;
        
    }
}
}

