
using Sudoku.controler.SetupController;
using Sudoku.controler.InputController;
using Sudoku.controler.GameController;
using Sudoku.data.Game.Enum;
using Sudoku.data.Game;
using Sudoku.data.EditorStates;
using Sudoku.view.GameView;
using Sudoku.view.Sudoku_board;

if (args.Any())
{
    var path = args[0];
    Sudoku.data.Boards.@abstract.Board board;

    if (File.Exists(path))
    {
        FileInfo fi = new FileInfo(path);
        string input = File.ReadAllText(fi.FullName);
        var DisplayOption = DisplayOptions.Easy;

        //TODO start the game
        board = new SetupBuilderController(new SetupBuilder()).buildBoard(fi.Extension, input);

        //clean this up
        GameContext gcontext = new GameContext(new GameSolvingState(), 
            board , DisplayOption, 
            EditorState.Help);

        InputHandlerController ihc = new InputHandlerController(gcontext);
        ihc.Subscribe(board);
        ihc.Subscribe(gcontext);
        var bv = new NineByNineBoardDrawingStrategy(board);
        
        SudokuGameView sgv = new SudokuGameView(gcontext, bv);
        GameController gc = new GameController(ihc, sgv, gcontext);
        gc.gameLoop();
    }
    else
    {
        Console.WriteLine("unsupported action");
        System.Environment.Exit(1); 
    }
    //todo get display option from args



}

// lijst files -> lees alle files uit
// user select file
// load file