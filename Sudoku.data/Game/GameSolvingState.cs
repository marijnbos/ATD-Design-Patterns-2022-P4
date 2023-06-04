using Sudoku.data.Game.State;
using Sudoku.data.Input.Enum;

namespace Sudoku.data.Game;

public class GameSolvingState : IGameState
{
    public void Move(PlayerInput input, GameContext context)
    {
        switch (input)
        {
            //stop solving state
            case PlayerInput.Quit:
                context.State = new InsertRealNumberState();
                return;
            default:
                Console.WriteLine("not valid input");
                return;
        }
    }

    public void insert(string value, GameContext context)
    {
        context.State = new InsertRealNumberState();
    }

    public void solve(GameContext context)
    {
        //TODO solve the board
        throw new NotImplementedException();

        //TODO set context to playing state
        context.State = new InsertRealNumberState();
    }
}