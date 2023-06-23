namespace Sudoku.view.Cell.Composit;

public abstract class CellComponent : IView
{
    public int Value { get; protected set; }
    public abstract void Draw();
}