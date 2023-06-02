
using Sudoku.controler.SetupController;

if (args.Any())
{
    var path = args[0];

    if (File.Exists(path))
    {
        FileInfo fi = new FileInfo(path);
        string input = File.ReadAllText(fi.FullName);
        //TODO start the game
        new SetupBuilderController(new SetupBuilder()).buildBoard(fi.Extension, input);
    }
}
// lijst files -> lees alle files uit
// user select file
// load file