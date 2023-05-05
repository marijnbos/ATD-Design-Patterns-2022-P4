namespace Sudoku.data.Boards.Factory;

public abstract class CreatorBoard
{
    public abstract Board factorMethod(List<List<Cell>> cells);
}