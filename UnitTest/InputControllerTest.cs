using Sudoku.controler.InputController;
using Sudoku.data.Boards;
using Sudoku.data.Boards.@abstract;
using Sudoku.data.Boards.Enum;
using Sudoku.data.EditorStates;
using Sudoku.data.Game;
using Sudoku.data.Game.Enum;
using Sudoku.data.Input.Enum;

namespace Sudoku.Tests;

public class InputControllerTest
{
    InputHandlerController inputHandlerController;
    private GameContext game;
    public InputControllerTest()
    {
        inputHandlerController = new InputHandlerController(new GameContext(new InsertingHelpNumbers(), new NineByNine("080030709190800000000700002016080000200905003000010920800007000000008095309050060", SudokuDisplayMode.Simple), DisplayOptions.Easy, new EditorState()));
    }

    [Fact]
    public void inputController_inValidInput_doensNotchangeGameDisplay()
    {
       // Arrange
       inputHandlerController.Subscribe(inputHandlerController.Game);
       game = inputHandlerController.Game;
       // Act
       inputHandlerController.SetPlayerInput("test");
       // Assert
       Assert.Equal(inputHandlerController.Game.DisplayOption, game.DisplayOption);
       
    }
    
    [Fact]
    public void inputController_validInput_changeGameDisplay()
    {
        // Arrange
        inputHandlerController.Subscribe(inputHandlerController.Game);
        game = inputHandlerController.Game;
        // Act
        inputHandlerController.SetPlayerInput("t");
        // Assert
        Assert.NotSame(inputHandlerController.Game.DisplayOption, game.DisplayOption);
    }
}