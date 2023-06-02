using Sudoku.data.Boards.@abstract;
using Sudoku.data.Boards.Enum;
using Sudoku.data.Boards.Interface;
using Sudoku.data.Cells.@abstract;
using Sudoku.data.Position;

namespace Sudoku.data.Boards;

public class Samurai : Board
{
    public Samurai(List<List<ProductCell>> cells, SudokuDisplayMode sudokuDisplayMode) :  base(cells, SudokuTypes.Samurai, sudokuDisplayMode)
    {
    }

    public override IConcreteBoard copy()
    {
        return new Jigsaw(new List<List<ProductCell>>(), SudokuDisplayMode);
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