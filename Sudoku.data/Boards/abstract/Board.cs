using Sudoku.data.Boards.Enum;
using Sudoku.data.Boards.Interface;
using Sudoku.data.Cells.@abstract;
using Sudoku.data.Cells.Factory;
using Sudoku.data.Input.Enum;
using Sudoku.data.Position;

namespace Sudoku.data.Boards.@abstract;

public abstract class Board : IConcreteBoard, ISolver, IObservable<IConcreteBoard>, IObserver<PlayerInput>
{
    private ICollection<IObserver<IConcreteBoard>> _observers;
    public uint NumberOfGroups { get; set; }
    public List<List<ProductCell>> Cells { get; set; }
    public SudokuDisplayMode SudokuDisplayMode { get; set; }

    public SudokuTypes Type { get; }
    public Pos SelectedCell { get; set; }
    public Board SolvedBoard {get;set;}

    public int Size { get { return Cells.Count; } }

    protected Board(string inputCells, SudokuTypes type, SudokuDisplayMode sudokuDisplayMode)
    {
        _observers = new List<IObserver<IConcreteBoard>>();
        Type = type;
        SudokuDisplayMode = sudokuDisplayMode;
        SelectedCell = new Pos(0, 0);
        Cells = CreateBoard(inputCells);
        SolvedBoard = this.getSolvedBoard();
    }

    public abstract Board getSolvedBoard();
    public abstract Board validateBoard();
    public abstract IConcreteBoard copy();

    protected List<List<ProductCell>> CopyCells()
    {
        var copiedCells = new List<List<ProductCell>>();

        foreach (var row in Cells)
        {
            var copiedRow = new List<ProductCell>();
            foreach (var cell in row)
            {
                CellFactory cellFactory = new CellFactory();
                ProductCell copiedCell = cellFactory.factorMethod((cell.Group), cell.Value, cell.Selected, cell.State);
                copiedRow.Add(copiedCell);
            }
            copiedCells.Add(copiedRow);
        }
        return copiedCells;
    }

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

