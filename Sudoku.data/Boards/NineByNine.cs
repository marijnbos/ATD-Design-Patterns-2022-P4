using Sudoku.data.Position;

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