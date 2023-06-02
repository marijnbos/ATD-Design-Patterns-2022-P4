using Sudoku.data.Game.State;
using Sudoku.data.Input.Enum;

namespace Sudoku.data.Game;

public class InsertingHelpNumbers : IGameState
{
    
 
    public void Move(PlayerInput input, GameContext context)
    {
        switch (input)
        {
            case PlayerInput.Quit:
                context.State = new InsertRealNumberState();
               return;
            default:
                //write a message to the console that the input is not valid and quit is only allowed to switch to other state
                return;
        }
    }

    public void insert(string value, GameContext context)
    {
        //if the input is a number
        //insert the number in the board
        throw new NotImplementedException();
    }

    public void solve(GameContext context)
    {
        //switch to soloving state
        context.State = new GameSolvingState();
    }
}