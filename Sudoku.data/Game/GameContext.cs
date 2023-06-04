using Sudoku.data.Boards.@abstract;
using Sudoku.data.Boards.Interface;
using Sudoku.data.EditorStates;
using Sudoku.data.Game.Enum;
using Sudoku.data.Game.State;
using Sudoku.data.Input.Enum;

namespace Sudoku.data.Game;

public class GameContext : IObserver<IConcreteBoard>
{
    public IGameState State { get; set; }
    public DisplayOptions DisplayOption { get; }
    public Board Board { get; }
    public EditorState EditorState { get; }
    public GameStatus GameStatus { get;}
    

    public GameContext(IGameState state, Board board, DisplayOptions displayOption, EditorState editorState)
    {
        State = state;
        Board = board;
        Board.Subscribe(this);
        DisplayOption = displayOption;
        EditorState = editorState;
        GameStatus = GameStatus.Ongoing;
    }

    public void Move(PlayerInput input)
    {
        State.Move(input, this);
    }

    public void solve()
    {
        State.solve(this);
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

    public void OnNext(IConcreteBoard value)
    {
        throw new NotImplementedException();
    }
    
  
}