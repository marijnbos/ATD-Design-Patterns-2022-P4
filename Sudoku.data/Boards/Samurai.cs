using Sudoku.data.Position;

namespace Sudoku.data.Boards;

public class Samurai : Board
{
    public Samurai(List<List<ProductCell>> Cells, SudokuDisplayMode sudokuDisplayMode) :  base(Cells, SudokuTypes.Samurai, sudokuDisplayMode)
    {
    }

    public override IConcreteBoard copy()
    {
        return new Jigsaw(new List<List<ProductCell>>(), base.SudokuDisplayMode);
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