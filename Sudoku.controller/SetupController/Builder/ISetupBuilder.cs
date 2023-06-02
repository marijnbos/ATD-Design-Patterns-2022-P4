using Sudoku.data.Boards;
using Sudoku.data.Boards.@abstract;
using Sudoku.data.Boards.Enum;
using Sudoku.data.Cells.@abstract;

namespace Sudoku.controler.SetupController.Builder;

public interface ISetupBuilder
{
    
    //List<List<Cell>> cells, SudokuTypes type, SudokuDisplayMode sudokuDisplayMode
    public string cells { get; set; }
    public SudokuTypes type { get; set; }
    public SudokuDisplayMode sudokuDisplayMode { get; set; }
    ISetupBuilder setUpCells(string input);
    ISetupBuilder setUpType(string input);
    ISetupBuilder setUpDisplayMode(string input);
    Board buildBoard();
}