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

public class GameControllerTest
{
    GameController gameController;
    GameContext game;
    Board board;
    
    public GameControllerTest()
    {
        board = new NineByNine("700509001000000000150070063003904100000050000002106400390040076000000000600201004",
            SudokuDisplayMode.Assist);
  game = new GameContext(new GameSolvingState(),board, DisplayOptions.Easy, EditorState.Defenitive);
        new GameController(new InputHandlerController(game), new SudokuGameView(game, new NineByNineBoardDrawingStrategy(board), new ConcreteTestConsoleWrapper()), game);
        
      
    }
    
    [Fact]
    public void gameController_UpdateGameStatusValid_gameIsSolved()
    {
        // Arrange
        gameController = new GameController(new InputHandlerController(game), new SudokuGameView(game, new NineByNineBoardDrawingStrategy(new NineByNine("325681974798354261647298354237416589586932417149578321762195843453267198961843752", SudokuDisplayMode.Assist)),new ConcreteTestConsoleWrapper()), game);
        gameController.Game.Board.Cells = gameController.Game.Board.SolvedBoard.Cells;
        // Act
        gameController.Game.UpdateGameStatus();
        
        // Assert
        Assert.Equal(GameStatus.Finished, game.GameStatus);
    }
    
    [Fact]
    public void gameController_solveGame_gameIsNotSolved()
    {
        // Arrange
        gameController = new GameController(new InputHandlerController(game), new SudokuGameView(game, new NineByNineBoardDrawingStrategy(board), new ConcreteTestConsoleWrapper()), game);
        // Act
        gameController.Game.solve();
        // Assert
        Assert.True(GameStatus.Ongoing == game.GameStatus);
    }


    [Fact]
    public void gameController_SudokuGameViewIsNotNull()
    {
        // Arrange
        gameController = new GameController(new InputHandlerController(game), new SudokuGameView(game, new NineByNineBoardDrawingStrategy(board), new ConcreteTestConsoleWrapper()), game);
        // Assert
        Assert.NotNull(gameController.SudokuGameView);
    }
    [Fact]
    public void Gamecontroller_InputHandlerIsNotNull()
    {
        // Arrange
        gameController = new GameController(new InputHandlerController(game), new SudokuGameView(game, new NineByNineBoardDrawingStrategy(board), new ConcreteTestConsoleWrapper()), game);
        // Assert
        Assert.NotNull(gameController.InputHandler);
    }
}