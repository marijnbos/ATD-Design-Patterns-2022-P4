namespace Sudoku.data.Boards;

public class NineByNine : Board
{
    public NineByNine(List<List<Cell>> Cells) : base(Cells)
    {
    }

    public override IBoard copy()
    {
        //todo make this return a actual list of 9x9 cells
        return new NineByNine(new List<List<Cell>>());
    }
}