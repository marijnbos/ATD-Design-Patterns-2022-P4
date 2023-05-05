using Sudoku.data.Boards;
using Sudoku.data.Game.Enum;
using Sudoku.data.Game.State;

namespace Sudoku.data.Game;

public class Game : GameState
{
    
    public void Move(PlayerInput input, GameContext _context)
    {
        switch (input)
        {
            case PlayerInput.up:
                break;
            case PlayerInput.right:
                break;
            case PlayerInput.down:
                break;
            case PlayerInput.left:
                break;
            default:
                return;
        }
    }

    public  void solve(GameContext _context)
    {
        //switch to soloving state
        _context._state = new GameSolvingState();
    }


    public  void OnCompleted()
    {
        throw new NotImplementedException();
    }

    public  void OnError(Exception error)
    {
        throw new NotImplementedException();
    }

    public  void OnNext(IBoard value)
    {
        
    }
}