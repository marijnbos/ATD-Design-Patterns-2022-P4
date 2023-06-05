using Sudoku.controler.SetupController.Builder;
using Sudoku.data.Boards;
using Sudoku.data.Boards.@abstract;

namespace Sudoku.controler.SetupController;

public class SetupBuilderController
{
    private readonly ISetupBuilder _setupBuilder;

    public SetupBuilderController(ISetupBuilder setupBuilder)
    {
        _setupBuilder = setupBuilder;
    }

    //first cells, then type, then display mode
    public Board buildBoard(string fileExtestion, string input)
    {
        return _setupBuilder.setUpType(fileExtestion).setUpCells(input).setUpDisplayMode(input)
            .buildBoard();
    }
}