using Sudoku.controler.InputController;
using Sudoku.data.Boards.Enum;
using Sudoku.data.Color;
using Sudoku.data.Game;
using Sudoku.view.Cell;
using Sudoku.view.GameView;
using Sudoku.view.Sudoku_board.Abstract;

namespace Sudoku.controler.SetupController.GameViewBuilder.Interface;

public interface ISetupBuilderGame
{
    public InputHandlerController InputHandler { set; get; }
    public SudokuGameView SudokuGameView { set; get; }
    public GameContext GameContext { set; get; }
    public SudokuBoardView SudokuBoardView { get; set; }
    public List<List<CellView>> Cells { get; set; }
    
    //TODO add uint cluster
    ISetupBuilderGame setupCellView(string cells);
    ISetupBuilderGame setupBoardView(SudokuTypes type);
    ISetupBuilderGame setupGameView();
    ISetupBuilderGame setUpGameInputHandler(GameContext context);
    
    //last method
    GameController.GameController buildGameController();
}