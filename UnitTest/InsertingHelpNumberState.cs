using Sudoku.data.Boards;
using Sudoku.data.Boards.Enum;
using Sudoku.data.EditorStates;
using Sudoku.data.Game;
using Sudoku.data.Game.Enum;
using Sudoku.data.Input.Enum;

namespace UnitTest;

public class InsertingHelpNumberState
{
    private InsertingHelpNumbers InsertRealNumberState { get; set; }

    public InsertingHelpNumberState()
    {
        InsertRealNumberState = new InsertingHelpNumbers();
    }

    [Fact]
    public void stateShouldToggle_ValidInput_ShouldToggleState()
    {
        //Arrange
        var context = new GameContext(new InsertingHelpNumbers(),
            new NineByNine("530070000600195000098000060800060003400803001700020006060000280000419005000080079",
                SudokuDisplayMode.Assist), DisplayOptions.Easy, EditorState.Defenitive);
        context.State = InsertRealNumberState;
        //Act
        context.Move(PlayerInput.EditorToggle);
        //Assert
        Assert.IsType<InsertRealNumberState>(context.State);
    }
}