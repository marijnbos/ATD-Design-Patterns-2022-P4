using Sudoku.data.Boards;

namespace Sudoku.data.Game.State;

public interface GameState
{
    public void Move(PlayerInput input, GameContext _context);
    public void solve(GameContext _context);
    
}