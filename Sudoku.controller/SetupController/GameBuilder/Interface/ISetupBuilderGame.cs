using Sudoku.controler.InputController;
using Sudoku.data.Boards.Enum;
using Sudoku.data.EditorStates;
using Sudoku.data.Game;
using Sudoku.data.Game.Enum;
using Sudoku.data.Game.State;
using Sudoku.view.Cell;
using Sudoku.view.GameView;
using Sudoku.view.Sudoku_board.Abstract;

namespace Sudoku.controler.SetupController.GameControllerBuilder.Interface;

public interface ISetupBuilderGame
{
    public InputHandlerController InputHandler { set; get; }
    public SudokuGameView SudokuGameView { set; get; }
    public GameContext GameContext { set; get; }
    public SudokuBoardView SudokuBoardView { get; set; }
    public List<List<CellView>> Cells { get; set; }
    

    
    ISetupBuilderGame setupGameContext(IGameState state, data.Boards.@abstract.Board board, DisplayOptions displayOption, EditorState editorState);
    ISetupBuilderGame setupBoardView();
    ISetupBuilderGame setupGameView();
    ISetupBuilderGame setUpGameInputHandler();
    
    //last method
    GameController.GameController buildGameController();
}