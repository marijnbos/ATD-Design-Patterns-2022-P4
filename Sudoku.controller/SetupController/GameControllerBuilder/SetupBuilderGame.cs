using Sudoku.controler.InputController;
using Sudoku.controler.SetupController.GameViewBuilder.Interface;
using Sudoku.data.Boards.Enum;
using Sudoku.data.Color;
using Sudoku.data.Game;
using Sudoku.view.Cell;
using Sudoku.view.GameView;
using Sudoku.view.Sudoku_board.Abstract;
using Sudoku.view.Sudoku_board.Factory;

namespace Sudoku.controler.SetupController.GameViewBuilder;

public class SetupBuilderGame : ISetupBuilderGame
{
    public InputHandlerController InputHandler { get; set; }
    public SudokuGameView SudokuGameView { get; set; }
    public GameContext GameContext { get; set; }
    public SudokuBoardView SudokuBoardView { get; set; }
    public List<List<CellView>> Cells { get; set; }

    public ISetupBuilderGame setupCellView(string cell)
    {
        Cells = new List<List<CellView>>();
        return this;
    }

    public ISetupBuilderGame setupBoardView(SudokuTypes type)
    {
        SudokuBoardView = new ViewBoardFactory().factorMethod(SudokuDisplayMode.Simple, type, Cells);
        return this;
    }

    public ISetupBuilderGame setupGameView()
    {
        //TODO make this functional
        new SudokuGameView(SudokuBoardView);
        return this;
    }
    
    public ISetupBuilderGame setUpGameInputHandler(GameContext context)
    {
        //TODO make this functional
        new InputHandlerController(context);
        return this;
    }


    public GameController.GameController buildGameController()
    {
        return new GameController.GameController(InputHandler, SudokuGameView, GameContext);
    }
}