using Sudoku.controler.Builder;
using Sudoku.data.Boards;

namespace Sudoku.controler;


public class SetupBuilderController
{
    private readonly ISetupBuilder _setupBuilder;

    public SetupBuilderController(ISetupBuilder setupBuilder)
    {
        _setupBuilder = setupBuilder;
    }
    
    //first cells, then type, then display mode
    public Board buildBoard()
    {
        return _setupBuilder.setUpCells("exampleInput").setUpType("exampleInput").setUpDisplayMode("exampleInput")
            .buildBoard();
    }
}