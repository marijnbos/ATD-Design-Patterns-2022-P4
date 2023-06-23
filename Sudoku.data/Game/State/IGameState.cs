using Sudoku.data.Input.Enum;

namespace Sudoku.data.Game.State;

public interface IGameState
{
    public void Move(PlayerInput input, GameContext context);
    public void Insert(string value, GameContext context);
}