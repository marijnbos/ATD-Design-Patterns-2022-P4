using Sudoku.data.Position;

namespace Sudoku.data.Boards;

public class Jigsaw : Board
{
    public Jigsaw(List<List<Cell>> Cells) : base(Cells)
    {
    }

    public override IBoard copy()
    {
        return new Jigsaw(new List<List<Cell>>());
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