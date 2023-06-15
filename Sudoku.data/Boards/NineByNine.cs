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
    public override int Size {get {return 9;}}

    public int GroupHeight  { get {return 3;}}
    public int GroupWidth { get{return 3;}}


    public NineByNine(string cells, SudokuDisplayMode sudokuDisplayMode) : base(cells, sudokuDisplayMode)
    {
    }

    public override IConcreteBoard copy()
    {
        NineByNine clone = (NineByNine) MemberwiseClone();
        clone.SudokuDisplayMode = SudokuDisplayMode;
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


    public override void init()
    {
        this.SolvedBoard = (NineByNine)copy();
        Accept(new SudokuSolverVisitor());
    }

      public override void Accept(ISudokuVistor vistor)
    {
        vistor.Visit(this);
    }
}