using Sudoku.data.Boards.@abstract;
using Sudoku.data.Boards.Enum;
using Sudoku.data.Boards.Interface;
using Sudoku.data.Cells.@abstract;
using Sudoku.data.Position;

namespace Sudoku.data.Boards;

public class Jigsaw : Board
{
    public override int Size {get{return 6;}} 
    public Jigsaw(string cells, SudokuDisplayMode sudokuDisplayMode) : base(cells,  sudokuDisplayMode)
    {
    }

    public override IConcreteBoard copy()
    {
        Jigsaw clone = (Jigsaw) MemberwiseClone();
        clone.SudokuDisplayMode = SudokuDisplayMode;
        clone.Cells = CopyCells();
        clone.SolvedBoard = SolvedBoard;
        return clone;
    }

    public override List<List<ProductCell>> CreateBoard(string cells)
    {
        throw new NotImplementedException();
    }

    public override void init()
    {
        this.SolvedBoard = (Jigsaw)copy();
        Accept(new SudokuSolverVisitor());
    }



    public override void Accept(ISudokuVistor vistor)
    {
        vistor.Visit(this);
    }
}

