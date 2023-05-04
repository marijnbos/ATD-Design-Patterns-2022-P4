namespace Sudoku.data.Boards;

//todo check if I can rewrite this using types
public interface solver
{
    Board getSolvedBoard();

    public Board validateBoard();
}