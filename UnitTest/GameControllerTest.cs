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

public class GameControllerTest
{
    private GameController _gameController;
    private readonly GameContext _game;
    private readonly Board _board;

    public GameControllerTest()
    {
        _board = new NineByNine("700509001000000000150070063003904100000050000002106400390040076000000000600201004",
            SudokuDisplayMode.Assist);
        _game = new GameContext(new InsertRealNumberState(), _board, DisplayOptions.Easy, EditorState.Defenitive);
    }

    [Fact]
    public void gameController_UpdateGameStatusValid_gameIsSolved()
    {
        // Arrange
        _gameController = new GameController(new InputHandlerController(_game),
            new SudokuGameView(_game,
                new NineByNineBoardDrawingStrategy(new NineByNine(
                    "325681974798354261647298354237416589586932417149578321762195843453267198961843752",
                    SudokuDisplayMode.Assist)), new ConcreteTestConsoleWrapper()), _game);
        _gameController.Game.Board.Cells = _gameController.Game.Board.SolvedBoard.Cells;
        // Act
        _gameController.Game.UpdateGameStatus();

        // Assert
        Assert.Equal(GameStatus.Finished, _game.GameStatus);
    }

    [Fact]
    public void gameController_GameStateOnInitalised_gameIsNotSolved()
    {
        // Act & Arrange
        _gameController = new GameController(new InputHandlerController(_game),
            new SudokuGameView(_game, new NineByNineBoardDrawingStrategy(_board), new ConcreteTestConsoleWrapper()),
            _game);

        // Assert
        Assert.True(GameStatus.Ongoing == _game.GameStatus);
    }


    [Fact]
    public void gameController_SudokuGameViewIsNotNull()
    {
        // Arrange
        _gameController = new GameController(new InputHandlerController(_game),
            new SudokuGameView(_game, new NineByNineBoardDrawingStrategy(_board), new ConcreteTestConsoleWrapper()),
            _game);
        // Assert
        Assert.NotNull(_gameController.SudokuGameView);
    }

    [Fact]
    public void Gamecontroller_InputHandlerIsNotNull()
    {
        // Arrange
        _gameController = new GameController(new InputHandlerController(_game),
            new SudokuGameView(_game, new NineByNineBoardDrawingStrategy(_board), new ConcreteTestConsoleWrapper()),
            _game);
        // Assert
        Assert.NotNull(_gameController.InputHandler);
    }
}