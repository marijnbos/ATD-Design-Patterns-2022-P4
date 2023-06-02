using Sudoku.data.Position;

namespace Sudoku.data.Boards;

public class SixBySix : Board
{
    public SixBySix(List<List<ProductCell>> Cells, SudokuDisplayMode sudokuDisplayMode) : base(Cells, SudokuTypes.SixBySix, sudokuDisplayMode)
    {
    }

    public override IConcreteBoard copy()
    {
        //todo make this return a new sixbysix board
        return new SixBySix(new List<List<ProductCell>>(), base.SudokuDisplayMode);
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