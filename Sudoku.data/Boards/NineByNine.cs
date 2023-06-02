using Sudoku.data.Boards.@abstract;
using Sudoku.data.Boards.Enum;
using Sudoku.data.Boards.Interface;
using Sudoku.data.Cells.@abstract;
using Sudoku.data.Position;

namespace Sudoku.data.Boards;

public class NineByNine : Board
{
    public NineByNine(string cells, SudokuDisplayMode sudokuDisplayMode) :  base(cells, SudokuTypes.NineByNine, sudokuDisplayMode)
    {
    }

    public override IConcreteBoard copy()
    {
        //todo make this return a actual list of 9x9 cells
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