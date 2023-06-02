using Sudoku.controler.Builder;
using Sudoku.data;
using Sudoku.data.Boards;
using Sudoku.data.Boards.Factory;

namespace Sudoku.controler;

public class SetupBuilder : ISetupBuilder
{
    //generates the board needed
    private BoardFactory _boardFactory = new();
    
    public ISetupBuilder setUpCells(string Input)
    {
        return this;
    }

    public ISetupBuilder setUpType(string Input)
    {
        return this;
    }

    public ISetupBuilder setUpDisplayMode(string Input)
    {
        return this;
    }

    public Board buildBoard()
    {
     return _boardFactory.factorMethod(new List<List<ProductCell>>(), new SudokuTypes(), new SudokuDisplayMode());
    }
}