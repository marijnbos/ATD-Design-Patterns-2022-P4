using Sudoku.controler.SetupController.Builder;
using Sudoku.data.Boards;
using Sudoku.data.Boards.@abstract;
using Sudoku.data.Boards.Enum;
using Sudoku.data.Boards.Factory;
using Sudoku.data.Cells.@abstract;

namespace Sudoku.controler.SetupController;

public class SetupBuilder : ISetupBuilder
{
    //generates the board needed
    private BoardFactory _boardFactory = new();
    public string cells { get; set; }
    public SudokuTypes type { get; set; }
    public SudokuDisplayMode sudokuDisplayMode { get; set; }

    public ISetupBuilder setUpCells(string input)
    {
        
        cells = input;
        return this;
    }

    public ISetupBuilder setUpType(string input)
    {
        type = SudokuTypes.FourByFour;
        return this;
    }

    public ISetupBuilder setUpDisplayMode(string input)
    {
        sudokuDisplayMode = SudokuDisplayMode.Simple;
        return this;
    }

    public Board buildBoard()
    {
     return _boardFactory.factorMethod(cells, type, sudokuDisplayMode);
    }
}