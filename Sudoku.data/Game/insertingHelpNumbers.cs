namespace Sudoku.data.Game.State;

public class insertingHelpNumbers : IGameState
{
    
 
    public void Move(PlayerInput input, GameContext _context)
    {
        switch (input)
        {
            case PlayerInput.quit:
                _context.state = new InsertRealNumberState();
               return;
            default:
                //write a message to the console that the input is not valid and quit is only allowed to switch to other state
                return;
        }
    }

    public void insert(string value, GameContext _context)
    {
        //if the input is a number
        //insert the number in the board
        throw new NotImplementedException();
    }

    public void solve(GameContext _context)
    {
        //switch to soloving state
        _context.state = new GameSolvingState();
    }
}