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

namespace Sudoku.Tests;

public class SamuraiTest
{
    private Board board;
    private GameContext game;
    private SudokuGameView view;

    public SamuraiTest()
    {
        board = new Samurai(
            "800000700003050206700300095000091840000007002000062000000000000609080000002903000149000000000091000000060000007120008000000340405008067000000000000007020000050003000000000000008000000004000010600005030070080800005010000900000000800000000000000900060000030400000000000000390800407065000000200037600000080000000190000000000914000402800000080902000000000000610000400800000098750000670008001901060700002000009",
            SudokuDisplayMode.Assist);
        game = new GameContext(new InsertRealNumberState(), board, DisplayOptions.Easy, EditorState.Defenitive);
        view = new SudokuGameView(game, new SamuraiBoardDrawingStrategy(board), new ConcreteTestConsoleWrapper());
    }

    [Fact]
    public void Samurai_ValidSetup_RetunsRightAmountCells()
    {
        // Arrange
        var controller = new GameController(new InputHandlerController(game), view, game);

        // Act
        var rowCount = controller.Game.Board.Cells.Count();
        var totalCells = controller.Game.Board.Cells.Sum(x => x.Count);

        // Assert
        Assert.Equal(21, rowCount);
        Assert.Equal(441, totalCells);
    }

    [Fact]
    public void Samurai_InvalidSetup_RetunsIndexOutOfRangeException()
    {
        // Arrange & Assert
        Assert.Throws<IndexOutOfRangeException>(() => new Samurai("123", SudokuDisplayMode.Assist));
    }

    [Fact]
    public void Samurai_ValidSetup_PrintsBoard()
    {
        // Arrange
        var controller = new GameController(new InputHandlerController(game), view, game);

        // Act & Assert
        try
        {
            controller.SudokuGameView.Draw();
        }
        catch (Exception ex)
        {
            Assert.Fail("Expected no exception, but got: " + ex.Message);
        }
    }
}