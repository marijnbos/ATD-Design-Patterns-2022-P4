using Sudoku.data.Boards;

namespace Sudoku.controler.Strategy;

public interface IBoardStrategy
{
    void Exectute(SudokuTypes board);
}