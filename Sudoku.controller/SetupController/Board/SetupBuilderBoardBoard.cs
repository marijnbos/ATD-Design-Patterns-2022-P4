using Sudoku.controler.SetupController.Board.Interface;
using Sudoku.data.Boards.Enum;
using Sudoku.data.Boards.Factory;

namespace Sudoku.controler.SetupController.Board;

public class SetupBuilderBoardBoard : ISetupBuilderBoard
{
    //generates the board needed
    private BoardFactory _boardFactory = new();
    public string cells { get; set; }
    public SudokuTypes type { get; set; }
    public SudokuDisplayMode sudokuDisplayMode { get; set; }

    public ISetupBuilderBoard setUpCells(string input)
    {
        //TODO -> check if this needs more information at complexer types
        cells = input;
        return this;
    }

    public ISetupBuilderBoard setUpType(string input)
    {
        type = SudokuTypes.FourByFour;
        return this;
    }

    public ISetupBuilderBoard setUpDisplayMode(string input)
    {
        //default to simple, change to switch statement if needed by the requirements
        sudokuDisplayMode = SudokuDisplayMode.Simple;
        return this;
    }

    public data.Boards.@abstract.Board buildBoard()
    {
     return _boardFactory.factorMethod(cells, type, sudokuDisplayMode);
    }
}