using Sudoku.data.Boards;
using Sudoku.data.Game;
using Sudoku.data.Game.Enum;

namespace Sudoku.controler.Builder;

public interface ISetupBuilder
{
    ISetupBuilder SetBoard(string gameInput);
    ISetupBuilder setdisplayoptions(string displayOptions);

    Game Build();
}