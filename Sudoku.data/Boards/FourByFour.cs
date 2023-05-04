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
}