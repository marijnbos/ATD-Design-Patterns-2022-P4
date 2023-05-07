using Sudoku.data;
using Sudoku.data.Boards;

namespace Sudoku.controler.Builder;

public interface ISetupBuilder
{
    
    //List<List<Cell>> cells, SudokuTypes type, SudokuDisplayMode sudokuDisplayMode
    ISetupBuilder setUpCells(string Input);
    ISetupBuilder setUpType(string Input);
    ISetupBuilder setUpDisplayMode(string Input);
    Board buildBoard();
}