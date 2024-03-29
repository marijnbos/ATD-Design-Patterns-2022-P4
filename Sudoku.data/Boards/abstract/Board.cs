using Sudoku.data.Boards.Enum;
using Sudoku.data.Boards.Interface;
using Sudoku.data.Cells.@abstract;
using Sudoku.data.Cells.@enum;
using Sudoku.data.Cells.Factory;
using Sudoku.data.Input.Enum;
using Sudoku.data.Position;

namespace Sudoku.data.Boards.@abstract;

public abstract class Board : IConcreteBoard, IObserver<PlayerInput>
{
    private ICollection<IObserver<IConcreteBoard>> _observers;
    public uint NumberOfGroups { get; set; }
    public List<List<ProductCell>> Cells { get; set; }
    public SudokuDisplayMode SudokuDisplayMode { get; set; }
    public Pos SelectedCell { get; set; }
    public Board SolvedBoard { get; set; }

    public abstract int Size { get; }

    protected Board(string inputCells, SudokuDisplayMode sudokuDisplayMode)
    {
        _observers = new List<IObserver<IConcreteBoard>>();

        SudokuDisplayMode = sudokuDisplayMode;
        SelectedCell = new Pos(0, 0);
        Cells = CreateBoard(inputCells);
        init();
    }

    public abstract void init();
    public abstract IConcreteBoard copy();


    public List<List<ProductCell>> CopyCells()
    {
        var copiedCells = new List<List<ProductCell>>();
        if (Cells == null)
            throw new Exception("The board must have 81 cells");
        foreach (var row in Cells)
        {
            var copiedRow = new List<ProductCell>();
            foreach (var cell in row)
            {
                var cellFactory = new CellFactory();
                var copiedCell =
                    cellFactory.factorMethod(cell.Group, cell.Value, cell.Selected, cell.State, new List<int>());
                copiedRow.Add(copiedCell);
            }

            copiedCells.Add(copiedRow);
        }

        return copiedCells;
    }

    public abstract List<List<ProductCell>> CreateBoard(string cells);

    public Board validateBoard()
    {
        var factory = new CellFactory();
        for (var rowIndex = 0; rowIndex < Size; rowIndex++)
        {
            for (var columnIndex = 0; columnIndex < Size; columnIndex++)
            {
                var solvedCell = SolvedBoard.Cells[rowIndex][columnIndex];
                var currentCell = Cells[rowIndex][columnIndex];

                if (currentCell.Value != solvedCell.Value)
                {
                    Cells[rowIndex][columnIndex] = factory.factorMethod(solvedCell.Group, solvedCell.Value,
                        solvedCell.Selected, CellState.FaultyCell, new List<int>());
                }
                else
                {
                    Cells[rowIndex][columnIndex] = factory.factorMethod(solvedCell.Group, solvedCell.Value,
                        solvedCell.Selected, CellState.CorrectCell, new List<int>());
                }
            }
        }
        return this;
    }

    public IDisposable Subscribe(IObserver<IConcreteBoard> observer)
    {
        _observers.Add(observer);
        return new Unsubscriber.Unsubscriber(_observers, observer);
    }

    public void move(Pos move)
    {
        var selectedCell = Cells.SelectMany(row => row).FirstOrDefault(cell => cell.Selected);

        if (selectedCell != null)
        {
            var currentRow = Cells.FindIndex(row => row.Contains(selectedCell));
            var currentColumn = Cells[currentRow].FindIndex(cell => cell == selectedCell);

            var newRow = currentRow + move.X;
            var newColumn = currentColumn + move.Y;

            if (newRow >= 0 && newRow < Size && newColumn >= 0 && newColumn < Size)
            {
                selectedCell.Selected = false;
                selectedCell = Cells[newRow][newColumn];
                SelectedCell = new Pos(newColumn, newRow);
                selectedCell.Selected = true;
            }
        }
    }

    public abstract void Accept(ISudokuVistor vistor);

    public ProductCell GetCell(int row, int column)
    {
        return Cells[row][column];
    }

    public void OnCompleted()
    {
        return;
    }

    public void OnError(Exception error)
    {
        //throw new ArgumentOutOfRangeException(error.ToString());
        return;
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

    public bool IsCompleted()
    {
        var validCellStates = new[] {CellState.CorrectCell, CellState.FaultyCell, CellState.FilledSystem};

        return Cells.SelectMany(row => row)
            .All(cell => validCellStates.Contains(cell.State));
    }
}