namespace Sudoku.data.Position;

public class Pos
{
    public int Y { get; set; }
    public int X { get; set; }

    public Pos(int y, int x)
    {
        this.X = x;
        this.Y = y;
    }
}