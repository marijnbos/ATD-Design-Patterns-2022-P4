using Sudoku.controler.GameController;
using Sudoku.controler.InputController;
using Sudoku.controler.SetupController;
using Sudoku.controler.SetupController.Board;
using Sudoku.controler.SetupController.GameViewBuilder;
using Sudoku.data.EditorStates;
using Sudoku.data.Game;
using Sudoku.data.Game.Enum;
using Sudoku.view.GameView;
using Sudoku.view.Sudoku_board;
using Sudoku.view.Sudoku_board.Abstract;

if (args.Any())
{
    var path = args[0];
    if (File.Exists(path))
    {
        FileInfo fi = new FileInfo(path);
        string input = File.ReadAllText(fi.FullName);
        var board = new SetupBuilderController(new SetupBuilderBoardBoard()).buildBoard(fi.Extension, input);
        
        //TODO Make a builder that does these steps ^ v
        var context = new GameContext(new InsertRealNumberState(),
            board, DisplayOptions.Easy, EditorState.Defenitive);
        
        var gameController =
            new SetupBuilderController(new SetupBuilderGame()).buildGameController(input, board.Type, context);
    }
}