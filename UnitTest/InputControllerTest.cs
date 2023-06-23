using Sudoku.controler.InputController;
using Sudoku.data.Boards;
using Sudoku.data.Boards.Enum;
using Sudoku.data.EditorStates;
using Sudoku.data.Game;
using Sudoku.data.Game.Enum;

namespace UnitTest;

public class InputControllerTest
{
    private readonly InputHandlerController _inputHandlerController;
    private GameContext _game;

    public InputControllerTest()
    {
        _inputHandlerController = new InputHandlerController(new GameContext(new InsertingHelpNumbers(),
            new NineByNine("080030709190800000000700002016080000200905003000010920800007000000008095309050060",
                SudokuDisplayMode.Simple), DisplayOptions.Easy, new EditorState()));
    }

    [Fact]
    public void inputController_inValidInput_doensNotchangeGameDisplay()
    {
        // Arrange
        _inputHandlerController.Subscribe(_inputHandlerController.Game);
        _game = _inputHandlerController.Game;
        // Act
        _inputHandlerController.SetPlayerInput("test");
        // Assert
        Assert.Equal(_inputHandlerController.Game.DisplayOption, _game.DisplayOption);
    }

    [Fact]
    public void inputController_validInput_changeGameDisplay()
    {
        // Arrange
        _inputHandlerController.Subscribe(_inputHandlerController.Game);
        _game = _inputHandlerController.Game;
        // Act
        _inputHandlerController.SetPlayerInput("t");
        // Assert
        Assert.NotSame(_inputHandlerController.Game.DisplayOption, _game.DisplayOption);
    }
}