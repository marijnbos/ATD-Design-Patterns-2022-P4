using Sudoku.data.Position;

namespace Sudoku.data.Boards;

public class FourByFour : Board
{
    public FourByFour(List<List<ProductCell>> Cells, SudokuDisplayMode sudokuDisplayMode): base(Cells, SudokuTypes.FourByFour, sudokuDisplayMode)
    {
      
    }

    public override IConcreteBoard copy()
    {
        //todo make this return a new fourbyfour board
        return new FourByFour(new List<List<ProductCell>>(), base.SudokuDisplayMode);
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