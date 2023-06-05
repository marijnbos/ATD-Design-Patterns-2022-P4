using Sudoku.controler.SetupController;
using Sudoku.controler.InputController;
using Sudoku.controler.GameController;
using Sudoku.controler.SetupController.Board;
using Sudoku.controler.SetupController.GameControllerBuilder;
using Sudoku.data.Game.Enum;
using Sudoku.data.Game;
using Sudoku.data.EditorStates;
using Sudoku.view.GameView;
using Sudoku.view.Sudoku_board;

if (args.Any())
{
    var path = args[0];
    if (File.Exists(path))
    {
        FileInfo fi = new FileInfo(path);
        string input = File.ReadAllText(fi.FullName);
        var board = new SetupBuilderController(new SetupBuilderBoardBoard()).buildBoard(fi.Extension, input);

        //build the context in the same way as the game controller

        //make input handler subscribe to board and context
        var gameController =
            new SetupBuilderController(new SetupBuilderGame()).buildGameController(new InsertingHelpNumbers(), board,
                DisplayOptions.Easy, EditorState.Defenitive, input);
        gameController.gameLoop();
    }
    else
    {
        Console.WriteLine(path);
        Console.WriteLine("unsupported action");
        System.Environment.Exit(1);
    }
   
}
