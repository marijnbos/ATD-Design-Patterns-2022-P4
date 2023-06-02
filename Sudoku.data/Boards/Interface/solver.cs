using Sudoku.data.Boards.@abstract;

namespace Sudoku.data.Boards.Interface;

//todo check if I can rewrite this using types
public interface ISolver
{
    Board getSolvedBoard();

    public Board validateBoard();
}