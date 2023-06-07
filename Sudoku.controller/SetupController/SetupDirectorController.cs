using Sudoku.controler.SetupController.Board.Interface;
using Sudoku.controler.SetupController.GameControllerBuilder.Interface;
using Sudoku.data.EditorStates;
using Sudoku.data.Game.Enum;
using Sudoku.data.Game.State;

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
    {
        _setupBuilderGame = setupBuilderGame;
    }

    public data.Boards.@abstract.Board buildBoard(string fileExtestion, string input)
    {
        return _setupBuilderBoard.setUpType(fileExtestion).setUpCells(input).setUpDisplayMode(input)
            .buildBoard();
    }

    public GameController.GameController buildGameController(IGameState state, data.Boards.@abstract.Board board,
        DisplayOptions displayOption, EditorState editorState)
    {
        return _setupBuilderGame.setupGameContext(state, board, displayOption, editorState)
            .setupBoardView().setupGameView().setUpGameInputHandler().buildGameController();
    }
}