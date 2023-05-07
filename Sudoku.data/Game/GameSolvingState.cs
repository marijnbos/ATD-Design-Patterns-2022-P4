using Sudoku.data.Boards;
using Sudoku.data.Game.State;

namespace Sudoku.data.Game;

public class GameSolvingState : IGameState
{
    public void Move(PlayerInput input, GameContext _context)
    {
        switch (input)
        {
            //stop solving state
            case PlayerInput.quit:
                _context.state = new InsertRealNumberState();
                throw new NotImplementedException();
            default:
                //write a message to the console that the input is not valid and quit is only allowed
                return;
        }
    }

    public void insert(string value, GameContext _context)
    {
        _context.state = new InsertRealNumberState();
    }

    public void solve(GameContext _context)
    {
        //solve the board
        throw new NotImplementedException();
        
        // set context to playing state
        
    }
    
}