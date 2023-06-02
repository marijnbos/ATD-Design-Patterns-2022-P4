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
    
    public ISetupBuilder setUpCells(string input)
    {
        return this;
    }

    public ISetupBuilder setUpType(string input)
    {
        return this;
    }

    public ISetupBuilder setUpDisplayMode(string input)
    {
        return this;
    }

    public Board buildBoard()
    {
     return _boardFactory.factorMethod(new List<List<ProductCell>>(), new SudokuTypes(), new SudokuDisplayMode());
    }
}