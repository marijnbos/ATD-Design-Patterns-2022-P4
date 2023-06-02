using Sudoku.data.Boards.@abstract;
using Sudoku.data.Boards.Enum;
using Sudoku.data.Boards.Interface;
using Sudoku.data.Cells.@abstract;
using Sudoku.data.Position;

namespace Sudoku.data.Boards;

public class SixBySix : Board
{
    public SixBySix(List<List<ProductCell>> cells, SudokuDisplayMode sudokuDisplayMode) : base(cells, SudokuTypes.SixBySix, sudokuDisplayMode)
    {
    }

    public override IConcreteBoard copy()
    {
        //todo make this return a new sixbysix board
        return new SixBySix(new List<List<ProductCell>>(), SudokuDisplayMode);
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