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
                throw new NotImplementedException();
            default:
                //write a message to the console that the input is not valid and quit is only allowed
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
        context.Board.getSolvedBoard();

        //TODO set context to playing state
        context.State = new InsertRealNumberState();
    }

}