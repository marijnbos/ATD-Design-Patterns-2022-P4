namespace Sudoku.data.Boards;

//todo check if I can rewrite this using types
public interface ISolver
{
    Board getSolvedBoard();

    public Board validateBoard();
}