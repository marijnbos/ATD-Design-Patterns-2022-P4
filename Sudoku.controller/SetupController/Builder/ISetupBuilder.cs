using Sudoku.data.Boards;
using Sudoku.data.Boards.@abstract;

namespace Sudoku.controler.SetupController.Builder;

public interface ISetupBuilder
{
    
    //List<List<Cell>> cells, SudokuTypes type, SudokuDisplayMode sudokuDisplayMode
    ISetupBuilder setUpCells(string input);
    ISetupBuilder setUpType(string input);
    ISetupBuilder setUpDisplayMode(string input);
    Board buildBoard();
}