using Sudoku.controler.Builder;
using Sudoku.data;
using Sudoku.data.Boards;
using Sudoku.data.Game;
using Sudoku.data.Game.Enum;

namespace Sudoku.controler;

public class setupBuilder : ISetupBuilder
{
    // builder with inport strategy as filename
    public ISetupBuilder SetBoard(string gameInput)
    {
        switch (gameInput)
        {
                
        }
        return null;
    }

    public ISetupBuilder setdisplayoptions(string displayOptions)
    {
        switch (displayOptions)
        {
                
        }
        return null;
    }

    public Game Build()
    {
        // flexible with builder
        return new Game(new Jigsaw(new List<List<Cell>>()), DisplayOptions.Easy);
    }
}