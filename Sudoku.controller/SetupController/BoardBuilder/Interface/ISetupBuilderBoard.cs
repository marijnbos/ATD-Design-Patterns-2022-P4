using Sudoku.data.Boards.Enum;

namespace Sudoku.controler.SetupController.Board.Interface;

public interface ISetupBuilderBoard
{

    //List<List<Cell>> cells, SudokuTypes type, SudokuDisplayMode sudokuDisplayMode
    public string cells { get; set; }
    public SudokuTypes type { get; set; }
    public SudokuDisplayMode sudokuDisplayMode { get; set; }
    ISetupBuilderBoard setUpCells(string input);
    ISetupBuilderBoard setUpType(string input);
    ISetupBuilderBoard setUpDisplayMode(string input);
    data.Boards.@abstract.Board buildBoard();
}