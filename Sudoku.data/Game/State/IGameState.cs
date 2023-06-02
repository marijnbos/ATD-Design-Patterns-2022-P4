using Sudoku.data.Input.Enum;

namespace Sudoku.data.Game.State;

public interface IGameState
{
    
    //used for moving and accesing game elements
    public void Move(PlayerInput input, GameContext context);
    
    //used for inserting numbers
    public void insert(string value, GameContext context);
    
    //used for solving the game 
    public void solve(GameContext context);
    
}