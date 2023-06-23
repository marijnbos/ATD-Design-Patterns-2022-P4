using Sudoku.data.Boards.@abstract;
using Sudoku.data.Boards.Enum;
using Sudoku.data.Boards.Interface;
using Sudoku.data.Cells.@abstract;
using Sudoku.data.Cells.@enum;
using Sudoku.data.Cells.Factory;
using Sudoku.data.Position;

namespace Sudoku.data.Boards;

public class NineByNine : Board, IFixedGroupDimensionsSizeBoard
{
    public override int Size => 9;

    public int GroupHeight => 3;
    public int GroupWidth => 3;


    public NineByNine(string cells, SudokuDisplayMode sudokuDisplayMode) : base(cells, sudokuDisplayMode)
    {
    }

    public override IConcreteBoard copy()
    {
        var clone = (NineByNine) MemberwiseClone();
        clone.SudokuDisplayMode = SudokuDisplayMode;
        clone.Cells = CopyCells();
        clone.SolvedBoard = SolvedBoard;
        return clone;
    }

    public override List<List<ProductCell>> CreateBoard(string cells)
    {
        var board = new List<List<ProductCell>>();
        var group = 0;
        for (var i = 0; i < Size; i++)
        {
            var row = new List<ProductCell>();
            for (var j = 0; j < Size; j++)
            {
                var cellValue = cells[i * Size + j];
                var selected = i == 0 && j == 0 ? true : false;
                row.Add(new CellFactory().factorMethod(group, cellValue, selected,
                    cellValue == '0' ? CellState.Empty : CellState.FilledSystem, new List<int>()));
                group++;
            }

            board.Add(row);
        }

        if (cells.Length != 81) throw new Exception("The board must have 81 cells");
        return board;
    }


    public override void init()
    {
        SolvedBoard = (NineByNine) copy();
        Accept(new SudokuSolverVisitor());
    }

    public override void Accept(ISudokuVistor vistor)
    {
        vistor.Visit(this);
    }
}