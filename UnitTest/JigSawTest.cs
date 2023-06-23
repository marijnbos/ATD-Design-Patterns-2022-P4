using Sudoku.controler.GameController;
using Sudoku.controler.InputController;
using Sudoku.data.Boards;
using Sudoku.data.Boards.@abstract;
using Sudoku.data.Boards.Enum;
using Sudoku.data.EditorStates;
using Sudoku.data.Game;
using Sudoku.data.Game.Enum;
using Sudoku.view.GameView;
using Sudoku.view.StrategyConsoleWrapper;
using Sudoku.view.Sudoku_board;

namespace UnitTest;

public class JigSawTest
{
    private readonly GameContext _game;
    private readonly SudokuGameView _view;

    public JigSawTest()
    {
        Board board = new Jigsaw(
            "SumoCueV1=0J0=8J0=0J0=0J1=0J2=0J2=0J2=5J2=0J2=8J3=0J0=0J1=0J1=0J2=7J2=0J4=0J4=5J4=0J3=0J0=0J1=0J1=9J2=0J2=0J5=0J6=0J4=0J3=7J0=0J1=1J1=6J5=9J5=0J5=0J6=0J4=0J3=0J0=4J1=3J1=0J5=1J7=8J7=0J6=0J4=0J3=0J0=0J5=8J5=7J5=6J7=0J7=3J6=0J4=0J3=0J0=0J5=0J8=5J8=0J7=0J7=0J6=0J4=3J3=0J3=0J3=6J8=0J8=0J7=0J7=0J6=2J4=0J8=9J8=0J8=0J8=0J8=0J7=0J6=8J6=0J6",
            SudokuDisplayMode.Assist);
        _game = new GameContext(new InsertingHelpNumbers(), board, DisplayOptions.Easy, EditorState.Defenitive);
        _view = new SudokuGameView(_game, new JigsawBoardDrawingStrategy(board), new ConcreteTestConsoleWrapper());
    }

    [Fact]
    public void Jigsaw_ValidSetup_RetunsRightAmountCells()
    {
        // Arrange
        var controller = new GameController(new InputHandlerController(_game), _view, _game);

        // Act
        var rowCount = controller.Game.Board.Cells.Count();
        var totalCount = controller.Game.Board.Cells.Sum(x => x.Count);

        // Assert
        Assert.Equal(9, rowCount);
        Assert.Equal(81, totalCount);
    }

    [Fact]
    public void Jigsaw_InvalidSetup_RetunsIndexOutOfRangeException()
    {
        // Arrange & Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => new Jigsaw("123", SudokuDisplayMode.Assist));
    }

    [Fact]
    public void Jigsaw_ValidSetup_PrintsBoard()
    {
        // Arrange
        var controller = new GameController(new InputHandlerController(_game), _view, _game);

        // Act & Assert
        try
        {
            controller.SudokuGameView.Draw();
        }
        catch (Exception e)
        {
            Assert.True(false, e.Message);
        }
    }
}