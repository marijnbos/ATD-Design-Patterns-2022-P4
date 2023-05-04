namespace Sudoku.data.Boards;

public class SixBySix : Board
{
    public SixBySix(List<List<Cell>> Cells) : base(Cells)
    {
    }

    public override IBoard copy()
    {
        //todo make this return a new sixbysix board
        return new SixBySix(new List<List<Cell>>());
    }
}