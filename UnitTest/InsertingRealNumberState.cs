using Sudoku.data.Boards;
using Sudoku.data.Boards.Enum;
using Sudoku.data.EditorStates;
using Sudoku.data.Game;
using Sudoku.data.Game.Enum;
using Sudoku.data.Input.Enum;

namespace UnitTest;

public class InsertingRealNumberState
{
    private InsertRealNumberState InsertRealNumberState { get; set; }
    private GameContext Context { get; set; }

    public InsertingRealNumberState()
    {
        InsertRealNumberState = new InsertRealNumberState();
        Context = new GameContext(new InsertRealNumberState(),
            new NineByNine("030070000600195000098000060800060003400803001700020006060000280000419005000080079",
                SudokuDisplayMode.Assist), DisplayOptions.Easy, EditorState.Defenitive);
    }

    [Fact]
    public void stateShouldToggle_ValidInput_ShouldToggleState()
    {
        //Arrange
        Context.State = InsertRealNumberState;
        //Act
        Context.Move(PlayerInput.EditorToggle);
        //Assert
        Assert.IsType<InsertingHelpNumbers>(Context.State);
    }

    [Fact]
    public void stateShouldAccept_ValidInput_ShouldAcceptInput()
    {
        //Arrange
        Context.State = InsertRealNumberState;
        //Act
        Context.Move(PlayerInput.Down);
        //Assert
        Assert.Equal(9, Context.Board.GetCell(1, 0).Group);
    }

    [Fact]
    public void stateShouldNotAccept_InvalidInputOutBoardBounds_ShouldNotChangeSelectedCell()
    {
        //Arrange
        Context.State = InsertRealNumberState;
        //Act
        Context.Move(PlayerInput.Up);
        //Assert
        Assert.Equal(0, Context.Board.GetCell(0, 0).Group);
    }

    [Fact]
    public void insert_ValidInput_ChangesCell()
    {
        //Arrange
        Context.State = InsertRealNumberState;

        //act
        Context.State.insert("1", Context);

        //Assert
        Assert.True(Context.Board.GetCell(0, 0).Value.Equals('1'));
    }

    [Fact]
    public void insert_InvalidInput_ThrowsFormatExpection()
    {
        //Arrange
        Context.State = InsertRealNumberState;

        //act && Assert
        Assert.Throws<FormatException>(() => Context.State.insert("99999", Context));
    }
}