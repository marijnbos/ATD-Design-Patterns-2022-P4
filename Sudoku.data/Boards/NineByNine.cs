using Sudoku.data.Boards.@abstract;
using Sudoku.data.Boards.Enum;
using Sudoku.data.Boards.Interface;
using Sudoku.data.Cells.@abstract;
using Sudoku.data.Cells.@enum;
using Sudoku.data.Cells.Factory;
using Sudoku.data.Position;

namespace Sudoku.data.Boards;

public class NineByNine : Board
{

    public NineByNine(string cells, SudokuDisplayMode sudokuDisplayMode) : base(cells, SudokuTypes.NineByNine, sudokuDisplayMode)
    {
    }

    public override IConcreteBoard copy()
    {
        NineByNine clone = (NineByNine) this.MemberwiseClone();
        clone.SudokuDisplayMode = this.SudokuDisplayMode;
        clone.Cells = CopyCells();
        clone.SolvedBoard = SolvedBoard;
        return clone;
    }

    public override List<List<ProductCell>> CreateBoard(string cells)
    {
        var board = new List<List<ProductCell>>();
        int group = 0;
        for (int i = 0; i < Size; i++)
        {
            var row = new List<ProductCell>();
            for (int j = 0; j < Size; j++)
            {
                char cellValue = cells[i * Size + j];
                bool selected = (i == 0 && j == 0) ? true : false;
                row.Add(new CellFactory().factorMethod(group, cellValue, selected, (cellValue == '0') ? CellState.Empty : CellState.FilledSystem, new List<int>()));
                group++;
            }
            board.Add(row);
        }

        if(cells.Length != 81) throw new Exception("The board must have 81 cells");
        return board;
    }
    public override void move(Pos move)
    {
        var old = Cells[SelectedCell.X][SelectedCell.Y];
        int newRow = SelectedCell.X + move.X;
        int newColumn = SelectedCell.Y + move.Y;

        if (newRow >= 0 && newRow < Size && newColumn >= 0 && newColumn < Size)
        {
            old.Selected = false;
            var selectedCell = Cells[newRow][newColumn];
            SelectedCell = new Pos(newColumn, newRow);
            selectedCell.Selected = true;
        }
    }


//todo rename initSolvedBoard
//no output
public override Board getSolvedBoard()
{
    this.SolvedBoard = (NineByNine)copy();
    Accept(new SudokuSolverVisitor());
    return null;  
}

    public override Board validateBoard()
    {
        var factory = new CellFactory();
            for (int i = 0; i < Size; i++)
                {
                for (int j = 0; j < Size; j++)
                {

                    var cell = SolvedBoard.Cells[i][j];
                    if (this.Cells[i][j].State == data.Cells.@enum.CellState.FilledUser &&
                        this.Cells[i][j].Value != SolvedBoard.Cells[i][j].Value)
                    {
                        this.Cells[i][j] = factory.factorMethod(cell.Group, cell.Value,
                         cell.Selected, data.Cells.@enum.CellState.FaultyCell, new List<int>());
                    }
                    else if (this.Cells[i][j].State == data.Cells.@enum.CellState.FilledUser &&
                        this.Cells[i][j].Value == SolvedBoard.Cells[i][j].Value)
                    {
                        this.Cells[i][j] = factory.factorMethod(cell.Group, cell.Value,
                         cell.Selected, CellState.CorrectCell, new List<int>());
                    }
                }
            }
        return this;
    }

    public override void Accept(ISudokuVistor vistor)
    {
        vistor.Visit(this);
    }
}