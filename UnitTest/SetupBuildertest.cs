using Sudoku.controler.SetupController;
using Sudoku.controler.SetupController.BoardBuilder;
using Sudoku.controler.SetupController.GameControllerBuilder;
using Sudoku.data.Boards;
using Sudoku.data.Boards.Enum;
using Sudoku.data.Boards.Factory;
using Sudoku.data.Cells.@abstract;
using Sudoku.data.EditorStates;
using Sudoku.data.Game;
using Sudoku.data.Game.Enum;

namespace Sudoku.Tests;

public class SetupBuildertest
{
    private SetupDirectorControllerBoard  _setupDirectorDirectorBoard;
    private SetupDirectorControllerGame  _setupBuilderDirectorGame;
    public SetupBuildertest()
    {
        _setupDirectorDirectorBoard = new SetupDirectorControllerBoard(new SetupBuilderBoard());
        _setupBuilderDirectorGame = new SetupDirectorControllerGame(new SetupBuilderGame());
    }
    [Fact]
    public void SetupDirectorControllerBoard_ValidInput_returnsBoard()
    {
        // Act
        var board = _setupDirectorDirectorBoard.buildBoard(".NineByNine", "530070000600195000098000060800060003400803001700020006060000280000419005000080079");
        // Assert
        Assert.Equal(9, board.Size);
        Assert.NotEqual(8, board.Size);
        Assert.NotEmpty(board.Cells);
    }

    [Fact]
    public void SetupDirectorControllerBoard_InvalidIput_throwsExeception()
    {
        // Assert & Act
        Assert.Throws<NotImplementedException>(() => _setupDirectorDirectorBoard.buildBoard(".INVALIDFILEEXTENSION", "530070000600195000098000060800060003400803001700020006060000280000419005000080079"));
    }
    

}