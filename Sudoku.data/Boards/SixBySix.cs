using Sudoku.data.Boards.@abstract;
using Sudoku.data.Boards.Enum;
using Sudoku.data.Boards.Interface;
using Sudoku.data.Cells.@abstract;
using Sudoku.data.Cells.@enum;
using Sudoku.data.Cells.Factory;
using Sudoku.data.Position;

namespace Sudoku.data.Boards;

public class SixBySix : Board, IFixedGroupDimensionsSizeBoard
{
    public override int Size => 6;

    public int GroupHeight => 2;
    public int GroupWidth => 3;

    public SixBySix(string cells, SudokuDisplayMode sudokuDisplayMode) : base(cells, sudokuDisplayMode)
    {
    }

    public override IConcreteBoard copy()
    {
        var clone = (SixBySix) MemberwiseClone();
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

        return board;
    }

    public override void init()
    {
        SolvedBoard = (SixBySix) copy();
        Accept(new SudokuSolverVisitor());
    }


    public override void Accept(ISudokuVistor vistor)
    {
        vistor.Visit(this);
    }
}