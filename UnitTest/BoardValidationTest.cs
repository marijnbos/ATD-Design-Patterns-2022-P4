using Sudoku.data.Boards;
using Sudoku.data.Boards.@abstract;
using Sudoku.data.Boards.Enum;

namespace UnitTest;

public class BoardValidationTest
{
    readonly List<Board> _board;

    public BoardValidationTest()
    {
        _board = new List<Board>();
        _board.Add(new FourByFour("0000000000000000", SudokuDisplayMode.Assist));
        _board.Add(new NineByNine("700509001000000000150070063003904100000050000002106400390040076000000000600201004", SudokuDisplayMode.Assist));
        _board.Add(new SixBySix("640200051000364002500436000640006025", SudokuDisplayMode.Simple));
    }

    [Fact]
    public void BoardValidation_ValidBoards_ThrowsNoError()
    {
        // Arrange
        try
        {
            // Act
            foreach (var board in _board)
            {
                // Assert
                board.Accept(new SudokuSolverVisitor());
            }
        }
        catch (Exception e)
        {
            Assert.True(false, e.Message);
        }
    }
    
    [Fact]
    public void BoardValidationFunction_ValidBoards_ThrowsNoError()
    {
        // Arrange
        try
        {
            // Act
            foreach (var board in _board)
            {
                // Assert
                board.validateBoard();
            }
        }
        catch (Exception e)
        {
            Assert.True(false, e.Message);
        }
    }
    
    
    //TODO (INFO) DIT IS TER DEMONSTRATIE VAN HET NUT VAN ONZE CONSOLEWRAPPER STRATEGY

    // [Fact]
    // public void StrategyConsoleWrapper_InvaldidConsoleWrapper_ThrowsErrror()
    // {
    //     //Arrange
    //     var consoleWrapper = new ConcreteConsoleWrapper();
    //     //Act & Assert
    //     Assert.Throws<IOException>(() => consoleWrapper.Clear());
    // }
}