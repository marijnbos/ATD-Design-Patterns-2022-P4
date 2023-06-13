using Sudoku.controler.SetupController.Board.Interface;
using Sudoku.data.Boards.Enum;
using Sudoku.data.Boards.Factory;

namespace Sudoku.controler.SetupController.Board;

public class SetupBuilderBoard : ISetupBuilderBoard
{
    //generates the board needed
    private BoardFactory _boardFactory = new();
    public string cells { get; set; }
    public string type { get; set; }
    public SudokuDisplayMode sudokuDisplayMode { get; set; }

    public ISetupBuilderBoard setUpCells(string input)
    {
        cells = input;
        return this;
    }

    public ISetupBuilderBoard setUpType(string input)
    {
        
        type = input.Remove(0, 1);
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