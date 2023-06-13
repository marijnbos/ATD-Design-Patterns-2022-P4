using Sudoku.controler.SetupController.GameControllerBuilder.Interface;
using Sudoku.data.EditorStates;
using Sudoku.data.Game.Enum;
using Sudoku.data.Game.State;

namespace Sudoku.controler.SetupController;

public class SetupDirectorControllerGame
{
    private readonly ISetupBuilderGame _setupBuilderGame ;

    public SetupDirectorControllerGame(ISetupBuilderGame setupBuilderGame)
    {
        _setupBuilderGame = setupBuilderGame;
    }

    public GameController.GameController buildGameController(IGameState state, data.Boards.@abstract.Board board,
        DisplayOptions displayOption, EditorState editorState)
    {
        return _setupBuilderGame.setupGameContext(state, board, displayOption, editorState)
            .setupBoardView().setupGameView().setUpGameInputHandler().buildGameController();
    }
    
}