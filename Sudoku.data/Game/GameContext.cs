using Sudoku.data.Boards;
using Sudoku.data.Game.Enum;
using Sudoku.data.Game.State;

namespace Sudoku.data.Game;

public class GameContext : IObserver<IBoard>
{
    public IGameState state { get; set; }
    public DisplayOptions displayOption { get; }
    public Board board { get; }
    public EditorState editorState { get; }
    public GameStatus gameStatus { get;}
    

    public GameContext(IGameState state, Board board, DisplayOptions displayOption, EditorState editorState)
    {
        this.state = state;
        this.board = board;
        this.board.Subscribe(this);
        this.displayOption = displayOption;
        this.editorState = editorState;
        this.gameStatus = GameStatus.ongoing;
    }

    public void Move(PlayerInput input)
    {
        state.Move(input, this);
    }

    public void solve()
    {
        state.solve(this);
        //if correct change game state
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

    public string Serialize(){
        throw new NotImplementedException();
    } 
}