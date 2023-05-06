using Sudoku.data.Boards;

namespace Sudoku.data.Game.State;

public interface IGameState
{
    
    //used for moving and accesing game elements
    public void Move(PlayerInput input, GameContext _context);
    
    //used for inserting numbers
    public void input(string value, GameContext _context);
    
    //used for solving the game 
    public void solve(GameContext _context);
    
}