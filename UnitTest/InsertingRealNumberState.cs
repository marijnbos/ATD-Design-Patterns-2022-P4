using Sudoku.data.Boards;
using Sudoku.data.Boards.Enum;
using Sudoku.data.EditorStates;
using Sudoku.data.Game;
using Sudoku.data.Game.Enum;
using Sudoku.data.Input.Enum;

namespace Sudoku.Tests;

public class InsertingRealNumberState
{
    InsertRealNumberState InsertRealNumberState { get; set; }
    GameContext context { get; set; }
    public InsertingRealNumberState()
    {
        InsertRealNumberState = new InsertRealNumberState();
        context = new GameContext(new InsertRealNumberState(),
            new NineByNine("030070000600195000098000060800060003400803001700020006060000280000419005000080079", SudokuDisplayMode.Assist), DisplayOptions.Easy, EditorState.Defenitive);

    }
    
    [Fact]
    public void stateShouldToggle_ValidInput_ShouldToggleState()
    {
        //Arrange
        context.State = InsertRealNumberState;
        //Act
        context.Move(PlayerInput.EditorToggle);
        //Assert
        Assert.IsType<InsertingHelpNumbers>(context.State);
    }
    
    [Fact]
    
    public void stateShouldAccept_ValidInput_ShouldAcceptInput()
    {
        //Arrange
        context.State = InsertRealNumberState;
        //Act
        context.Move(PlayerInput.Down);
        //Assert
        Assert.Equal(9, context.Board.GetCell(1, 0).Group);
    }
    
    [Fact]
    public void stateShouldNotAccept_InvalidInputOutBoardBounds_ShouldNotChangeSelectedCell()
    {
        //Arrange
        context.State = InsertRealNumberState;
        //Act
        context.Move(PlayerInput.Up);
        //Assert
        Assert.Equal(0, context.Board.GetCell(0, 0).Group);
    }
    
    [Fact]
    public void insert_ValidInput_ChangesCell()
    {
        //Arrange
        context.State = InsertRealNumberState;
        
        //act
        context.State.insert("1", context);
        
        //Assert
        Assert.True(context.Board.GetCell(0, 0).Value.Equals('1'));
 
    }
    
    [Fact]
    public void insert_InvalidInput_ThrowsFormatExpection()
    {
        //Arrange
        context.State = InsertRealNumberState;
        
        //act && Assert
      Assert.Throws<FormatException>(() => context.State.insert("99999", context));  

    }
}