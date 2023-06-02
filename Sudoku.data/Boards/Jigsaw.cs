using Sudoku.data.Boards.@abstract;
using Sudoku.data.Boards.Enum;
using Sudoku.data.Boards.Interface;
using Sudoku.data.Cells.@abstract;
using Sudoku.data.Position;

namespace Sudoku.data.Boards;

public class Jigsaw : Board
{
    public Jigsaw(string cells, SudokuDisplayMode sudokuDisplayMode) :  base(cells, SudokuTypes.Jigsaw, sudokuDisplayMode)
    {
    }

    public override IConcreteBoard copy()
    {
        throw new NotImplementedException();
    }

    public override List<List<ProductCell>> CreateBoard(string cells)
    {
        throw new NotImplementedException();
    }

    public override void move(Pos move)
    {
        throw new NotImplementedException();
    }

    public override Board getSolvedBoard()
    {
        throw new NotImplementedException();
    }

    public override Board validateBoard()
    {
        throw new NotImplementedException();
    }
}

