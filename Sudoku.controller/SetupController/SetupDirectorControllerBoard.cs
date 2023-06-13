using Sudoku.controler.SetupController.Board.Interface;
using Sudoku.controler.SetupController.GameControllerBuilder.Interface;
using Sudoku.data.EditorStates;
using Sudoku.data.Game.Enum;
using Sudoku.data.Game.State;

namespace Sudoku.controler.SetupController;

public class SetupBuilderController
{
    private readonly ISetupBuilderBoard _setupBuilderBoard;
   

    public SetupBuilderController(ISetupBuilderBoard setupBuilderBoard)
    {
        _setupBuilderBoard = setupBuilderBoard;
    }



    public data.Boards.@abstract.Board buildBoard(string fileExtestion, string input)
    {
        return _setupBuilderBoard.setUpType(fileExtestion).setUpCells(input).setUpDisplayMode(input)
            .buildBoard();
    }

   
}