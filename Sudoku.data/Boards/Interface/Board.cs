namespace Sudoku.data.Boards;


//todo marijn make solver beter >:(
public abstract class Board : IBoard, solver
{
    protected Board(List<List<Cell>> Cells)
    {
        this.Cells = Cells;
    }
    public uint NumberOfgroups { get; set; }
    public List<List<Cell>> Cells { get; set; }
    public abstract IBoard copy();
}