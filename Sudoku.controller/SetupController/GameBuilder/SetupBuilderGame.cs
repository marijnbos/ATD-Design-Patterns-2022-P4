using Sudoku.controler.InputController;
using Sudoku.controler.SetupController.GameControllerBuilder.Interface;
using Sudoku.data.EditorStates;
using Sudoku.data.Game;
using Sudoku.data.Game.Enum;
using Sudoku.data.Game.State;
using Sudoku.view.Cell;
using Sudoku.view.GameView;
using Sudoku.view.Sudoku_board.Abstract;
using Sudoku.view.Sudoku_board.Factory;

namespace Sudoku.controler.SetupController.GameControllerBuilder;

public class SetupBuilderGame : ISetupBuilderGame
{
    public InputHandlerController InputHandler { get; set; }
    public SudokuGameView SudokuGameView { get; set; }
    public GameContext GameContext { get; set; }
    public SudokuBoardView SudokuBoardView { get; set; }
    public List<List<CellView>> Cells { get; set; }


    public ISetupBuilderGame setupGameContext(IGameState state, data.Boards.@abstract.Board board,
        DisplayOptions displayOption,
        EditorState editorState)
    {
        GameContext = new GameContext(state, board, displayOption, editorState);
        return this;
    }

    public ISetupBuilderGame setupBoardView()
    {
        SudokuBoardView = new ViewBoardFactory().factorMethod(GameContext.Board);
        return this;
    }

    public ISetupBuilderGame setupGameView()
    {
        SudokuGameView = new SudokuGameView(GameContext, SudokuBoardView);
        return this;
    }

    public ISetupBuilderGame setUpGameInputHandler()
    {
        InputHandler = new InputHandlerController(GameContext);
        InputHandler.Subscribe(GameContext.Board);
        InputHandler.Subscribe(GameContext);
        return this;
    }


    public GameController.GameController buildGameController()
    {
        return new GameController.GameController(InputHandler, SudokuGameView, GameContext);
    }
}