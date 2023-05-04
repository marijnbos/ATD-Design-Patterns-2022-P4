using Sudoku.data.Position;

namespace Sudoku.data.Boards;

public class FourByFour : Board
{
    public FourByFour(List<List<Cell>> Cells) : base(Cells)
    {
    }

    public override IBoard copy()
    {
        //todo make this return a new fourbyfour board
        return new FourByFour(new List<List<Cell>>());
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