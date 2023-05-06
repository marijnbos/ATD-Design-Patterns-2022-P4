using Sudoku.data.Boards;
using Sudoku.data.Game.Enum;
using Sudoku.data.Game.State;

namespace Sudoku.data.Game;

public class GameContext : IObserver<IBoard>
{
    public IGameState _state { get; set; }
    DisplayOptions DisplayOption { get; }
    Board board { get; }
    EditorState EdiitorState { get; }
    

    public GameContext(IGameState state, Board board, DisplayOptions displayOption)
    {
        _state = state;
        this.board = board;
        this.board.Subscribe(this);
        DisplayOption = displayOption;
        EdiitorState = EditorState.hulp;
    }

    public void Move(PlayerInput input)
    {
        _state.Move(input, this);
    }

    public void solve()
    {
        _state.solve(this);
    }

    public void OnCompleted()
    {
        throw new NotImplementedException();
    }

    public void OnError(Exception error)
    {
        throw new NotImplementedException();
    }

    public void OnNext(IBoard value)
    {
        throw new NotImplementedException();
    }
}