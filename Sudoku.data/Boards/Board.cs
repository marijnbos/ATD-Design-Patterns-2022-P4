namespace Sudoku.data.Boards;

public class Board : IBoard, solver
{
    public uint NumberOfgroups { get; set; }
    public List<List<Cell>> Cells { get; set; }
    
    //todo rename -> getsolvedboardcopy?
    public Board getSolvedBoard()
    {
        //todo make this getSolvedBoard the board and return a new list of the board (protoype design pattern)
        return copy();
    }

    public Board copy()
    {
        return new Board();
    }
}