using Sudoku.controler.SetupController.Board.Interface;
using Sudoku.controler.SetupController.GameViewBuilder.Interface;
using Sudoku.data.Boards.Enum;
using Sudoku.data.Game;

namespace Sudoku.controler.SetupController;

public class SetupBuilderController
{
    private readonly ISetupBuilderBoard _setupBuilderBoard = null!;
    private readonly ISetupBuilderGame _setupBuilderGame = null!;

    public SetupBuilderController(ISetupBuilderBoard setupBuilderBoard)
    {
        _setupBuilderBoard = setupBuilderBoard;
       
    }

    public SetupBuilderController(ISetupBuilderGame setupBuilderGame)
    { _setupBuilderGame = setupBuilderGame;
        
    }

public data.Boards.@abstract.Board buildBoard(string fileExtestion, string input)
    {
        return _setupBuilderBoard.setUpType(fileExtestion).setUpCells(input).setUpDisplayMode(input)
            .buildBoard();
    }
    
    public GameController.GameController buildGameController(string cells,SudokuTypes type, GameContext context)
    {
        return _setupBuilderGame.setupCellView(cells).setupBoardView(type).setupGameView().setUpGameInputHandler(context).buildGameController();
    }
}