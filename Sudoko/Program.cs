using Sudoku.controler.SetupController;
using Sudoku.controler.SetupController.Board;
using Sudoku.controler.SetupController.BoardBuilder;
using Sudoku.controler.SetupController.GameControllerBuilder;
using Sudoku.data.EditorStates;
using Sudoku.data.Game;
using Sudoku.data.Game.Enum;

if (args.Any())
{
    var path = args[0];
    if (File.Exists(path))
    {
        var fi = new FileInfo(path);
        var input = File.ReadAllText(fi.FullName);
        var board = new SetupDirectorControllerBoard(new SetupBuilderBoard()).buildBoard(fi.Extension, input);
        var gameController =
            new SetupDirectorControllerGame(new SetupBuilderGame()).buildGameController(new InsertRealNumberState(),
                board,
                DisplayOptions.Easy, EditorState.Defenitive);
        gameController.gameLoop();
    }
    else
    {
        Console.WriteLine("unsupported action");
        Environment.Exit(1);
    }
}