using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sudoku.controler.Builder;
using Sudoku.data;
using Sudoku.data.Boards;
using Sudoku.data.Game;
using Sudoku.data.Game.Enum;

namespace Sudoku.controler
{
    public class SetUpController
    {
        private readonly ISetupBuilder _builder;

        public SetUpController(ISetupBuilder builder)
        {
            _builder = builder;
        }

        public Game BuidStandardGame(string gameInput, string displayOptions)
        {
            return _builder.SetBoard(gameInput)
                .setdisplayoptions(displayOptions).Build();
        }
    }
}